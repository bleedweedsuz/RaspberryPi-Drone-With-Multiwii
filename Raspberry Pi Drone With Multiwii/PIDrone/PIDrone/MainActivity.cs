using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Transitions;
using System.Threading;
using PIDrone.ControlsSets;
using System.Data.SqlClient;
using NativeWifi;
namespace PIDrone
{
    public partial class MainActivity : Form
    {
        WlanClient wlanClient = new WlanClient();
        List<NData> nData = new List<NData>();
        public Wlan.WlanAvailableNetwork currentNetwork;
        XNADrawPanel xnaDP;
        public static CircularProgressBar.CircularProgressBar cBarProgressBar;
        Panel CurrentPanel, OldPanel; System.Drawing.Size PanelSize; bool isTransitionsComplete=true;
        public static bool loaded = false;
        public static int PanelIndexValue = 0;
        SSHCore sshCore;
        List<String> CMDListTemp = new List<string>();
        int cIndex = 0;
        int count = 0;
        public MainActivity()
        {
            InitializeComponent();
        }
        private void MainActivity_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            SetDataFromDatabase();
            CustomControl();
            CustomTabEventControl();
            JoystickTimer.Start();
            LoadInterfaceAndList();
            sContainer.SplitterDistance = sContainer.Height - 205;
            sshCore = new SSHCore(SSHDebug,this);
        }
        #region "UI Region"
        #region "CUSTOM TAB CONTROL + XNA Draw Panel"
        public void CustomControl()
        {

            #region "XNA INIT"
            /******************XNA INIT******************/
            DrawPanelBox.Location = new Point(0, 0);
            xnaDP = new XNADrawPanel();
            xnaDP.Dock = DockStyle.Fill;
            DrawPanelBox.Controls.Add(xnaDP);
            DrawPanelBox.Dock = DockStyle.Fill;
            #endregion
            #region "CUSTOM TAB CONTROL"

           

            PanelSize = new System.Drawing.Size(BasePanel.Width, BasePanel.Height);
            CurrentPanel = BSC_Panel;
            //------------------------------------------>Some offset adjustment
            BSC_Panel.Size = PanelSize; GC_Panel.Size = PanelSize; IC_Panel.Size = PanelSize; MCS_Panel.Size = PanelSize; SSH_Panel.Size = PanelSize; ABT_Panel.Size = PanelSize;
            //------------------------------------------------------------------------------------------------------>
            BSC_Panel.Location = new Point(0, 0); GC_Panel.Location = new Point(-PanelSize.Width, 0);
            IC_Panel.Location = new Point(-PanelSize.Width, 0); MCS_Panel.Location = new Point(-PanelSize.Width, 0);
            SSH_Panel.Location = new Point(-PanelSize.Width, 0); ABT_Panel.Location = new Point(-PanelSize.Width, 0);


            BSC_Panel.Visible = true;
            GC_Panel.Visible = true;
            IC_Panel.Visible = true;
            MCS_Panel.Visible = true;
            SSH_Panel.Visible = true;
            ABT_Panel.Visible = true;
            #endregion
        }
        public void CustomTabEventControl()
        {
            tab_BSC.EventRegister(Click_BaseStationControl);
            tab_IC.EventRegister(Click_InputControl);
            tab_MCS.EventRegister(Click_MotorControlStation);
            tab_GC.EventRegister(Click_GeneralConfiguration);
            tab_SSH.EventRegister(Click_SSHClient);
            tab_ABT.EventRegister(Click_ABT);
        }
        private void ClearTabBtnSelect()
        {
            tab_BSC.IsButtonSelected = false;
            tab_GC.IsButtonSelected = false;
            tab_IC.IsButtonSelected = false;
            tab_MCS.IsButtonSelected = false;
            tab_SSH.IsButtonSelected = false;
            tab_ABT.IsButtonSelected = false;
        }
        private void Click_BaseStationControl()
        {
            ClearTabBtnSelect();
            tab_BSC.ToggleSelect();
            AnimationTransaction(BSC_Panel);
        }
        private void Click_InputControl()
        {
            ClearTabBtnSelect();
            tab_IC.ToggleSelect();

            AnimationTransaction(IC_Panel);
        }
        private void Click_MotorControlStation()
        {
            ClearTabBtnSelect();
            tab_MCS.ToggleSelect();

            AnimationTransaction(MCS_Panel);
        }
        private void Click_GeneralConfiguration()
        {
            ClearTabBtnSelect();
            tab_GC.ToggleSelect();

            AnimationTransaction(GC_Panel);
        }
        private void Click_SSHClient()
        {
            ClearTabBtnSelect();
            tab_SSH.ToggleSelect();
            AnimationTransaction(SSH_Panel);
            SSHCMDLine.Focus();
        }
        private void Click_ABT()
        {
            ClearTabBtnSelect();
            tab_ABT.ToggleSelect();
            AnimationTransaction(ABT_Panel);
        }
        private void AnimationTransaction(Panel _currentPanel)
        {
            if (CurrentPanel == _currentPanel) { return; }
            isTransitionsComplete = false;
            OldPanel = CurrentPanel;
            CurrentPanel = _currentPanel;

            BasePanel.BackColor = CurrentPanel.BackColor;

            PanelSize = new System.Drawing.Size(BasePanel.Width, BasePanel.Height);
            CurrentPanel.Size = PanelSize;

            Transition transitions1 = new Transition(new TransitionType_EaseInEaseOut(250)); transitions1.add(OldPanel, "Left", PanelSize.Width);
            Transition transitions2 = new Transition(new TransitionType_EaseInEaseOut(250)); transitions2.add(CurrentPanel, "Left", 0);
            transitions1.run();
            transitions2.run();
            transitions1.TransitionCompletedEvent += transitions1_TransitionCompletedEvent;

            if (CurrentPanel == BSC_Panel) { PanelIndexValue = 0; }
            else if (CurrentPanel == IC_Panel) { PanelIndexValue = 1; }
            else if (CurrentPanel == MCS_Panel) { PanelIndexValue = 2; }
            else if (CurrentPanel == GC_Panel) { PanelIndexValue = 3; }
            else if (CurrentPanel == SSH_Panel) { PanelIndexValue = 4; }
        }
        void transitions1_TransitionCompletedEvent(object sender, Transition.Args e)
        {
            OldPanel.Location = (new Point(-PanelSize.Width, 0));
            isTransitionsComplete = true;
        }
        #endregion
        #endregion
        #region "Connector Region"
        #endregion
        #region "FORM --->" 
        private void BasePanel_Resize(object sender, EventArgs e)
        {
            #region "PSIZE_UI_TABCONTROL"
            if (isTransitionsComplete)
            {
                try
                {
                    PanelSize = new System.Drawing.Size(BasePanel.Width, BasePanel.Height);
                    CurrentPanel.Size = PanelSize;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            #endregion
        }
        private void JoystickTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                JoystickTimer.Stop();
                //Axes
                XAxis.Text = ControlsSets.BaseControlStation_TabControls.Axes_X_Axis_Scaled.ToString();
                YAxis.Text = ControlsSets.BaseControlStation_TabControls.Axes_Y_Axis_Scaled.ToString();
                TAxisL.Text = ControlsSets.BaseControlStation_TabControls.Axes_Trigger_Left_Scaled.ToString();
                TAxisR.Text = ControlsSets.BaseControlStation_TabControls.Axes_Trigger_Right_Scaled.ToString();
                XRotation.Text = ControlsSets.BaseControlStation_TabControls.Axes_X_Rotation_Scaled.ToString();
                YRotation.Text = ControlsSets.BaseControlStation_TabControls.Axes_Y_Rotation_Scaled.ToString();
                AxesTrigger.Text = ControlsSets.BaseControlStation_TabControls.Axes_Trigger_Scaled.ToString();
                //Buttons
                BtnX.Text = ControlsSets.BaseControlStation_TabControls.Buttons_X.ToString();
                BtnY.Text = ControlsSets.BaseControlStation_TabControls.Buttons_Y.ToString();
                BtnA.Text = ControlsSets.BaseControlStation_TabControls.Buttons_A.ToString();
                BtnB.Text = ControlsSets.BaseControlStation_TabControls.Buttons_B.ToString();
                BtnLB.Text = ControlsSets.BaseControlStation_TabControls.Buttons_LB.ToString();
                BtnRB.Text = ControlsSets.BaseControlStation_TabControls.Buttons_RB.ToString();
                BtnStart.Text = ControlsSets.BaseControlStation_TabControls.Buttons_Start.ToString();
                BtnBack.Text = ControlsSets.BaseControlStation_TabControls.Buttons_Back.ToString();
                BtnAB1.Text = ControlsSets.BaseControlStation_TabControls.Buttons_AnalogBtn1.ToString();
                BtnAB2.Text = ControlsSets.BaseControlStation_TabControls.Buttons_AnalogBtn2.ToString();
                //DPad
                if (ControlsSets.BaseControlStation_TabControls.DPad == 1){UPad.Visible = true;DPad.Visible = false;RPad.Visible = false;LPad.Visible = false;}else if (ControlsSets.BaseControlStation_TabControls.DPad == 2){UPad.Visible = false;DPad.Visible = true;RPad.Visible = false;LPad.Visible = false;}else if (ControlsSets.BaseControlStation_TabControls.DPad == 3){UPad.Visible = false;DPad.Visible = false;RPad.Visible = false;LPad.Visible = true;}else if (ControlsSets.BaseControlStation_TabControls.DPad == 4){UPad.Visible = false;DPad.Visible = false;RPad.Visible = true;LPad.Visible = false;}else{ UPad.Visible = false;DPad.Visible = false;RPad.Visible = false;LPad.Visible = false;}
                
                //Status //1 connection
                Status_.Text = "Status: ";
                if (xnaDP.BCS_Controls.tcpCore != null){Status_.Text += xnaDP.BCS_Controls.tcpCore.ConnectionStatus;}else{Status_.Text += "Closed Connection";}

                JoystickTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void sContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            BStationLable.Focus();//just focusing other control//just incase
        }
        private void MainActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xnaDP != null)
            {
                xnaDP.BCS_Controls.DisposeMe();
            }
        }
        #region "Input Control Region"
        private void Input_ResetBtn_Click(object sender, EventArgs e)
        {
            //just reseting the value
            Rmax.Value = 2000; Rmin.Value = 1000;
            Amax.Value = 2000; Amin.Value = 1000;
            Tmax.Value = 2000; Tmin.Value = 1000;
            Emax.Value = 2000; Emin.Value = 1000;
            Aux_low.Value = 1200; Aux_mid.Value = 1500; Aux_high.Value = 1800;
        }
        private void Input_SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = DatabaseHelper.getNextSnNo("Id","TrimTable");
                DatabaseHelper.OpenConnection();
                DatabaseHelper.ExecuteQry("insert into TrimTable values (" + ID + "," + Tmax.Value + "," + Tmin.Value + "," + Rmax.Value + "," + Rmin.Value + "," + Emax.Value + "," + Emin.Value + "," + Amax.Value + "," + Amin.Value + "," + Aux_low.Value + "," + Aux_mid.Value +"," + Aux_high.Value +")", true);
                BaseControlStation_TabControls.MaxThrottle = (float) Tmax.Value;
                BaseControlStation_TabControls.MinThrottle = (float)Tmin.Value;
                BaseControlStation_TabControls.MaxRudder = (float)Rmax.Value;
                BaseControlStation_TabControls.MinRudder = (float)Rmin.Value;
                BaseControlStation_TabControls.MaxElevator = (float)Emax.Value;
                BaseControlStation_TabControls.MinElevator = (float)Emin.Value;
                BaseControlStation_TabControls.MaxAileron = (float)Amax.Value;
                BaseControlStation_TabControls.MinAileron = (float)Amin.Value;

                BaseControlStation_TabControls.AUXL = Convert.ToInt16(Aux_low.Value);
                BaseControlStation_TabControls.AUXM = Convert.ToInt16(Aux_mid.Value);
                BaseControlStation_TabControls.AUXH = Convert.ToInt16(Aux_high.Value);

                Msg("Status", "Trim Table Is Updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DatabaseHelper.CloseConnection();
            }
        }
        #endregion
        public void Msg(String title, String msg)
        {
            MsgPanel.Visible = true;
            msgTitle.Text = title;
            msgString.Text = msg;
            MessageBoxTimer.Start();
        }
        private void MessageBoxTimer_Tick(object sender, EventArgs e)
        {
            MsgPanel.Visible = false;
            MessageBoxTimer.Stop();
        }
        private void OpenPuttyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(puttyLocation.Text.ToString().Trim());
            }
            catch (Exception ex)
            {
                Msg("Error", ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        private void ReloadPuttyBtn_Click(object sender, EventArgs e)
        {
            LoadDataToPuttyVNC();
        }
        private void OpenVncViewerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(vncLocation.Text.ToString().Trim());
            }
            catch (Exception ex)
            {
                Msg("Error", ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        private void generalConfigReset_Click(object sender, EventArgs e)
        {
            gc_DIP.Text = "127.0.0.1";
            gc_CP.Text = "8000";
            gc_SP.Text = "8001";
            gc_IP.Text = "8002";
        }
        private void generalConfigSave_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = DatabaseHelper.getNextSnNo("Id", "GeneralConfig");
                DatabaseHelper.OpenConnection();

                List<SqlParameter> sqlParameter = new List<SqlParameter>();
                sqlParameter.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "Id", Value = ID });
                sqlParameter.Add(new SqlParameter() { SqlDbType = SqlDbType.Text, ParameterName = "IP", Value = gc_DIP.Text.ToString().Trim() });
                sqlParameter.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "ControlPort", Value = Convert.ToInt16(gc_CP.Text) });
                sqlParameter.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "StatusPort",Value = Convert.ToInt16(gc_SP.Text) });
                sqlParameter.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "ImagePort", Value = Convert.ToInt16(gc_IP.Text) });
                DatabaseHelper.ExecuteQryNonQry("insert into GeneralConfig values (@Id,@IP,@ControlPort,@StatusPort,@ImagePort)", sqlParameter);

                BaseControlStation_TabControls.IP_ADDRESS = gc_DIP.Text.ToString();
                BaseControlStation_TabControls.PORT_CONTROL = Convert.ToInt16(gc_CP.Text.ToString());
                BaseControlStation_TabControls.PORT_STATUS = Convert.ToInt16(gc_SP.Text.ToString());
                BaseControlStation_TabControls.PORT_IMAGE = Convert.ToInt16(gc_IP.Text.ToString());



                Msg("Status", "General Configure Table Is Updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DatabaseHelper.CloseConnection();
            }
        }
        private void SSH_reset_Click(object sender, EventArgs e)
        {
            puttyLocation.Clear();
            vncLocation.Clear();
        }
        private void SSH_Save_Click(object sender, EventArgs e)
        {
            //Save to database
            try
            {

                long ID = DatabaseHelper.getNextSnNo("Id", "sshTable");
                DatabaseHelper.OpenConnection();
                {
                    List<SqlParameter> sqlParameter = new List<SqlParameter>();
                    sqlParameter.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "Id", Value = ID });
                    sqlParameter.Add(new SqlParameter() { SqlDbType = SqlDbType.Text, ParameterName = "plocation", Value = puttyLocation.Text.ToString().Trim() });
                    sqlParameter.Add(new SqlParameter() { SqlDbType = SqlDbType.Text, ParameterName = "vnclocation", Value = vncLocation.Text.ToString().Trim() });
                    DatabaseHelper.ExecuteQryNonQry("insert into sshTable values (@Id,@plocation,@vnclocation)", sqlParameter);
                }
                Msg("Status", "SSH Table Is Updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DatabaseHelper.CloseConnection();
            }
        }
        #endregion  
        #region "WIFI FORM"
        private void ConnectWithAlreadySetProfileBtn_Click(object sender, EventArgs e)
        {

        } 
        private void wInterfaceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadInterfaceAndList()
        {
            try
            {
                nData.Clear();
                wifiList.Items.Clear();
                foreach (WlanClient.WlanInterface wlanIface in wlanClient.Interfaces)
                {
                    Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                    wifiList.Items.Add(wlanIface.NetworkInterface.Name.ToString());
                    nData.Add(new NData());//Add fake one First
                    foreach (Wlan.WlanAvailableNetwork network in networks)
                    {
                        Wlan.Dot11Ssid ssid = network.dot11Ssid;
                        String networkName = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
                        NData nd = new NData();
                        nd.wlanIface = wlanIface;
                        nd.Network = network;
                        nData.Add(nd);//Add real one
                        wifiList.Items.Add("    +" + networkName +
                            " [" + network.flags.HasFlag(Wlan.WlanAvailableNetworkFlags.Connected) + "] " +
                            network.wlanSignalQuality + "%");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Msg("ERROR", ex.ToString());
            }
        }
        private void wifiList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                NData nd = nData[wifiList.SelectedIndex];
                if (nd.isNetwork)
                {
                    Wlan.WlanAvailableNetwork network = nd.Network;
                    WlanClient.WlanInterface wlanIface = nd.wlanIface;
                    //------------------------------------------------
                    
                }
                Console.WriteLine("--------->");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Msg("ERROR", ex.ToString());
            }
        }
        private class NData
        {
            public bool isNetwork = false;
            public WlanClient.WlanInterface wlanIface;
            public Wlan.WlanAvailableNetwork Network;
        }
        #endregion
        #region "SetDatabaseData"
        private void SetDataFromDatabase()
        {
            LoadControlStationStaticData();
            LoadDataToPuttyVNC();
            LoadGeneralConfigData();
        }
        private void LoadDataToPuttyVNC()
        {
            //1 => Putty Location, 2 => VNC Viewer
            try
            {
                DatabaseHelper.OpenConnection();
                DatabaseHelper.ExecuteQry("select * from sshTable where Id = (select Max(Id) from sshTable)", false);
                DatabaseHelper.sqlDataReader.Read();
                if (DatabaseHelper.sqlDataReader.HasRows)
                {
                    puttyLocation.Text = DatabaseHelper.sqlDataReader[1].ToString();//Putty location
                    vncLocation.Text = DatabaseHelper.sqlDataReader[2].ToString();//VNC location
                }
                DatabaseHelper.sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DatabaseHelper.CloseConnection();
            }
        }
        private void LoadControlStationStaticData()
        {
            try
            {
                DatabaseHelper.OpenConnection();
                DatabaseHelper.ExecuteQry("select * from TrimTable where Id = (select Max(Id) from TrimTable)", false);
                DatabaseHelper.sqlDataReader.Read();
                if (DatabaseHelper.sqlDataReader.HasRows)
                {
                    BaseControlStation_TabControls.MaxThrottle = Convert.ToInt16(DatabaseHelper.sqlDataReader[1]);
                    BaseControlStation_TabControls.MinThrottle = Convert.ToInt16(DatabaseHelper.sqlDataReader[2]);
                    BaseControlStation_TabControls.MaxRudder = Convert.ToInt16(DatabaseHelper.sqlDataReader[3]);
                    BaseControlStation_TabControls.MinRudder = Convert.ToInt16(DatabaseHelper.sqlDataReader[4]);
                    BaseControlStation_TabControls.MaxElevator = Convert.ToInt16(DatabaseHelper.sqlDataReader[5]);
                    BaseControlStation_TabControls.MinElevator = Convert.ToInt16(DatabaseHelper.sqlDataReader[6]);
                    BaseControlStation_TabControls.MaxAileron = Convert.ToInt16(DatabaseHelper.sqlDataReader[7]);
                    BaseControlStation_TabControls.MinAileron = Convert.ToInt16(DatabaseHelper.sqlDataReader[8]);
                    BaseControlStation_TabControls.AUXL = Convert.ToInt16(DatabaseHelper.sqlDataReader[9]);
                    BaseControlStation_TabControls.AUXM = Convert.ToInt16(DatabaseHelper.sqlDataReader[10]);
                    BaseControlStation_TabControls.AUXH = Convert.ToInt16(DatabaseHelper.sqlDataReader[11]);

                    Tmax.Value = Convert.ToDecimal(DatabaseHelper.sqlDataReader[1]);
                    Tmin.Value = Convert.ToDecimal(DatabaseHelper.sqlDataReader[2]);
                    Rmax.Value = Convert.ToDecimal(DatabaseHelper.sqlDataReader[3]);
                    Rmin.Value = Convert.ToDecimal(DatabaseHelper.sqlDataReader[4]);
                    Emax.Value = Convert.ToDecimal(DatabaseHelper.sqlDataReader[5]);
                    Emin.Value = Convert.ToDecimal(DatabaseHelper.sqlDataReader[6]);
                    Amax.Value = Convert.ToDecimal(DatabaseHelper.sqlDataReader[7]);
                    Amin.Value = Convert.ToDecimal(DatabaseHelper.sqlDataReader[8]);
                    Aux_low.Value = Convert.ToInt16(DatabaseHelper.sqlDataReader[9]);
                    Aux_mid.Value = Convert.ToInt16(DatabaseHelper.sqlDataReader[10]);
                    Aux_high.Value = Convert.ToInt16(DatabaseHelper.sqlDataReader[11]);
                }
                DatabaseHelper.sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DatabaseHelper.CloseConnection();
            }
        }
        private void LoadGeneralConfigData()
        {
            try
            {
                DatabaseHelper.OpenConnection();
                DatabaseHelper.ExecuteQry("select * from GeneralConfig where Id = (select Max(Id) from GeneralConfig)", false);
                DatabaseHelper.sqlDataReader.Read();
                if (DatabaseHelper.sqlDataReader.HasRows)
                {
                    gc_DIP.Text = DatabaseHelper.sqlDataReader[1].ToString();//IP Address
                    gc_CP.Text = DatabaseHelper.sqlDataReader[2].ToString();//Control Port
                    gc_SP.Text = DatabaseHelper.sqlDataReader[3].ToString();//Status Port
                    gc_IP.Text = DatabaseHelper.sqlDataReader[4].ToString();//Image Port
                    //============================================================================================
                    BaseControlStation_TabControls.IP_ADDRESS = DatabaseHelper.sqlDataReader[1].ToString();
                    BaseControlStation_TabControls.PORT_CONTROL = Convert.ToInt16(DatabaseHelper.sqlDataReader[2]);
                    BaseControlStation_TabControls.PORT_STATUS = Convert.ToInt16(DatabaseHelper.sqlDataReader[3]);
                    BaseControlStation_TabControls.PORT_IMAGE = Convert.ToInt16(DatabaseHelper.sqlDataReader[4]);
                }
                DatabaseHelper.sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DatabaseHelper.CloseConnection();
            }
        }
        #endregion
        #region "SSH .NET CONSOLE"
        private void SSHCMDLine_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Up)
            {
                if (CMDListTemp.Count > 0)
                {
                    cIndex = CMDListTemp.Count - 1 - count;
                    if (cIndex < 0) { return; }
                    SSHCMDLine.Clear();
                    SSHCMDLine.Text = CMDListTemp[cIndex];
                    SSHCMDLine.Focus();
                    count++;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (CMDListTemp.Count > 0)
                {
                    if (cIndex >= CMDListTemp.Count) { return; }
                    SSHCMDLine.Clear();
                    cIndex = CMDListTemp.Count - 1 - count;
                    SSHCMDLine.Text = CMDListTemp[cIndex];
                    SSHCMDLine.Focus();
                    count--;
                }
            }
            else */
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (SSHCMDLine.Text.Length > 0)
                {
                    count = 0;
                    cIndex = 0;
                    String CMD = SSHCMDLine.Text.Trim();
                    sshCore.ExecuteCMD(CMD);
                    CMDListTemp.Add(CMD);
                    SSHCMDLine.Clear();
                    SSHCMDLine.Focus();
                }
            }
        }
        #endregion
        private void CMDLists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                SSHCMDLine.Text = CMDLists.Items[CMDLists.SelectedIndex].ToString();
                SSHCMDLine.Focus();
                CMDLists.ClearSelected();
            }
            catch (Exception ex)
            {
                Msg("ERROR", ex.ToString());
            }
        }
    }
}

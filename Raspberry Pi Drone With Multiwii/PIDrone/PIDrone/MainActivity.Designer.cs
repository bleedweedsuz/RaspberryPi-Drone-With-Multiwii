namespace PIDrone
{
    partial class MainActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainActivity));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.Status_ = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tab_ABT = new PIDrone.CustomButton();
            this.panel30 = new System.Windows.Forms.Panel();
            this.MsgPanel = new System.Windows.Forms.Panel();
            this.msgString = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.msgTitle = new System.Windows.Forms.Label();
            this.tab_SSH = new PIDrone.CustomButton();
            this.tab_GC = new PIDrone.CustomButton();
            this.tab_MCS = new PIDrone.CustomButton();
            this.tab_IC = new PIDrone.CustomButton();
            this.tab_BSC = new PIDrone.CustomButton();
            this.BasePanel = new System.Windows.Forms.Panel();
            this.SSH_Panel = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.CMDLists = new System.Windows.Forms.ListBox();
            this.SSHCMDLine = new System.Windows.Forms.TextBox();
            this.SSHDebug = new System.Windows.Forms.RichTextBox();
            this.panel37 = new System.Windows.Forms.Panel();
            this.SSH_reset = new System.Windows.Forms.Button();
            this.SSH_Save = new System.Windows.Forms.Button();
            this.vncLocation = new System.Windows.Forms.TextBox();
            this.OpenVncViewerBtn = new System.Windows.Forms.Button();
            this.ReloadPuttyBtn = new System.Windows.Forms.Button();
            this.puttyLocation = new System.Windows.Forms.TextBox();
            this.OpenPuttyBtn = new System.Windows.Forms.Button();
            this.GC_Panel = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.gc_DIP = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.gc_IP = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.gc_CP = new System.Windows.Forms.TextBox();
            this.gc_SP = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wifiList = new System.Windows.Forms.ListBox();
            this.label44 = new System.Windows.Forms.Label();
            this.panel35 = new System.Windows.Forms.Panel();
            this.generalConfigReset = new System.Windows.Forms.Button();
            this.generalConfigSave = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ABT_Panel = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.IC_Panel = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.Rmin = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.Rmax = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.Amin = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.Amax = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.Tmin = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.Tmax = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.Emin = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.Emax = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Aux_low = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Aux_mid = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.Aux_high = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.Input_ResetBtn = new System.Windows.Forms.Button();
            this.Input_SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BSC_Panel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BStationLable = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.UPad = new System.Windows.Forms.PictureBox();
            this.LPad = new System.Windows.Forms.PictureBox();
            this.DPad = new System.Windows.Forms.PictureBox();
            this.RPad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label58 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BtnAB2 = new System.Windows.Forms.Label();
            this.BtnAB1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Label();
            this.BtnLB = new System.Windows.Forms.Label();
            this.BtnRB = new System.Windows.Forms.Label();
            this.BtnA = new System.Windows.Forms.Label();
            this.BtnB = new System.Windows.Forms.Label();
            this.BtnY = new System.Windows.Forms.Label();
            this.BtnX = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.AxesTrigger = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.TAxisR = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.YRotation = new System.Windows.Forms.Label();
            this.XRotation = new System.Windows.Forms.Label();
            this.TAxisL = new System.Windows.Forms.Label();
            this.YAxis = new System.Windows.Forms.Label();
            this.XAxis = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MCS_Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.sContainer = new System.Windows.Forms.SplitContainer();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.DrawPanelBox = new System.Windows.Forms.Panel();
            this.BorderPanel = new System.Windows.Forms.Panel();
            this.JoystickTimer = new System.Windows.Forms.Timer(this.components);
            this.MessageBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.MainStatusStrip.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel30.SuspendLayout();
            this.MsgPanel.SuspendLayout();
            this.BasePanel.SuspendLayout();
            this.SSH_Panel.SuspendLayout();
            this.panel37.SuspendLayout();
            this.GC_Panel.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel35.SuspendLayout();
            this.ABT_Panel.SuspendLayout();
            this.IC_Panel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).BeginInit();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amin)).BeginInit();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amax)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tmin)).BeginInit();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tmax)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emin)).BeginInit();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emax)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aux_low)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aux_mid)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aux_high)).BeginInit();
            this.panel29.SuspendLayout();
            this.BSC_Panel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.MCS_Panel.SuspendLayout();
            this.panel31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).BeginInit();
            this.sContainer.Panel1.SuspendLayout();
            this.sContainer.Panel2.SuspendLayout();
            this.sContainer.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 749);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1064, 22);
            this.MainStatusStrip.TabIndex = 4;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // Status_
            // 
            this.Status_.BackColor = System.Drawing.Color.Transparent;
            this.Status_.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Status_.Name = "Status_";
            this.Status_.Size = new System.Drawing.Size(42, 17);
            this.Status_.Text = "Status:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tab_ABT);
            this.panel5.Controls.Add(this.panel30);
            this.panel5.Controls.Add(this.tab_SSH);
            this.panel5.Controls.Add(this.tab_GC);
            this.panel5.Controls.Add(this.tab_MCS);
            this.panel5.Controls.Add(this.tab_IC);
            this.panel5.Controls.Add(this.tab_BSC);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 749);
            this.panel5.TabIndex = 6;
            // 
            // tab_ABT
            // 
            this.tab_ABT.BackColor = System.Drawing.Color.White;
            this.tab_ABT.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_ABT.IconBoxValue = ((System.Drawing.Image)(resources.GetObject("tab_ABT.IconBoxValue")));
            this.tab_ABT.IsButtonSelected = false;
            this.tab_ABT.Location = new System.Drawing.Point(0, 200);
            this.tab_ABT.MaximumSize = new System.Drawing.Size(220, 40);
            this.tab_ABT.MinimumSize = new System.Drawing.Size(220, 40);
            this.tab_ABT.Name = "tab_ABT";
            this.tab_ABT.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.tab_ABT.Size = new System.Drawing.Size(220, 40);
            this.tab_ABT.TabIndex = 7;
            this.tab_ABT.TitleBoxValue = "About PI  Control Station";
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.MsgPanel);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel30.Location = new System.Drawing.Point(0, 649);
            this.panel30.Name = "panel30";
            this.panel30.Padding = new System.Windows.Forms.Padding(5);
            this.panel30.Size = new System.Drawing.Size(220, 100);
            this.panel30.TabIndex = 6;
            // 
            // MsgPanel
            // 
            this.MsgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MsgPanel.Controls.Add(this.msgString);
            this.MsgPanel.Controls.Add(this.panel32);
            this.MsgPanel.Controls.Add(this.msgTitle);
            this.MsgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgPanel.Location = new System.Drawing.Point(5, 5);
            this.MsgPanel.Name = "MsgPanel";
            this.MsgPanel.Size = new System.Drawing.Size(210, 90);
            this.MsgPanel.TabIndex = 5;
            this.MsgPanel.Visible = false;
            // 
            // msgString
            // 
            this.msgString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msgString.Location = new System.Drawing.Point(0, 27);
            this.msgString.Name = "msgString";
            this.msgString.Size = new System.Drawing.Size(210, 63);
            this.msgString.TabIndex = 2;
            this.msgString.Text = "msg";
            this.msgString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel32.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel32.Location = new System.Drawing.Point(0, 26);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(210, 1);
            this.panel32.TabIndex = 1;
            // 
            // msgTitle
            // 
            this.msgTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.msgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTitle.ForeColor = System.Drawing.Color.Maroon;
            this.msgTitle.Location = new System.Drawing.Point(0, 0);
            this.msgTitle.Name = "msgTitle";
            this.msgTitle.Size = new System.Drawing.Size(210, 26);
            this.msgTitle.TabIndex = 0;
            this.msgTitle.Text = "title";
            this.msgTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_SSH
            // 
            this.tab_SSH.BackColor = System.Drawing.Color.White;
            this.tab_SSH.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_SSH.IconBoxValue = global::PIDrone.Properties.Resources.ssh_img;
            this.tab_SSH.IsButtonSelected = false;
            this.tab_SSH.Location = new System.Drawing.Point(0, 160);
            this.tab_SSH.MaximumSize = new System.Drawing.Size(220, 40);
            this.tab_SSH.MinimumSize = new System.Drawing.Size(220, 40);
            this.tab_SSH.Name = "tab_SSH";
            this.tab_SSH.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.tab_SSH.Size = new System.Drawing.Size(220, 40);
            this.tab_SSH.TabIndex = 4;
            this.tab_SSH.TitleBoxValue = "SSH Client";
            // 
            // tab_GC
            // 
            this.tab_GC.BackColor = System.Drawing.Color.White;
            this.tab_GC.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_GC.IconBoxValue = global::PIDrone.Properties.Resources.config_img;
            this.tab_GC.IsButtonSelected = false;
            this.tab_GC.Location = new System.Drawing.Point(0, 120);
            this.tab_GC.MaximumSize = new System.Drawing.Size(220, 40);
            this.tab_GC.MinimumSize = new System.Drawing.Size(220, 40);
            this.tab_GC.Name = "tab_GC";
            this.tab_GC.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tab_GC.Size = new System.Drawing.Size(220, 40);
            this.tab_GC.TabIndex = 3;
            this.tab_GC.TitleBoxValue = "General Configuration";
            // 
            // tab_MCS
            // 
            this.tab_MCS.BackColor = System.Drawing.Color.White;
            this.tab_MCS.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_MCS.IconBoxValue = global::PIDrone.Properties.Resources.motor_img;
            this.tab_MCS.IsButtonSelected = false;
            this.tab_MCS.Location = new System.Drawing.Point(0, 80);
            this.tab_MCS.MaximumSize = new System.Drawing.Size(220, 40);
            this.tab_MCS.MinimumSize = new System.Drawing.Size(220, 40);
            this.tab_MCS.Name = "tab_MCS";
            this.tab_MCS.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tab_MCS.Size = new System.Drawing.Size(220, 40);
            this.tab_MCS.TabIndex = 2;
            this.tab_MCS.TitleBoxValue = "Motor Control";
            this.tab_MCS.Visible = false;
            // 
            // tab_IC
            // 
            this.tab_IC.BackColor = System.Drawing.Color.White;
            this.tab_IC.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_IC.IconBoxValue = global::PIDrone.Properties.Resources.joystick_img;
            this.tab_IC.IsButtonSelected = false;
            this.tab_IC.Location = new System.Drawing.Point(0, 40);
            this.tab_IC.MaximumSize = new System.Drawing.Size(220, 40);
            this.tab_IC.MinimumSize = new System.Drawing.Size(220, 40);
            this.tab_IC.Name = "tab_IC";
            this.tab_IC.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tab_IC.Size = new System.Drawing.Size(220, 40);
            this.tab_IC.TabIndex = 1;
            this.tab_IC.TitleBoxValue = "Input Control";
            // 
            // tab_BSC
            // 
            this.tab_BSC.BackColor = System.Drawing.Color.White;
            this.tab_BSC.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_BSC.IconBoxValue = global::PIDrone.Properties.Resources.monitor_img;
            this.tab_BSC.IsButtonSelected = true;
            this.tab_BSC.Location = new System.Drawing.Point(0, 0);
            this.tab_BSC.MaximumSize = new System.Drawing.Size(220, 40);
            this.tab_BSC.MinimumSize = new System.Drawing.Size(220, 40);
            this.tab_BSC.Name = "tab_BSC";
            this.tab_BSC.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.tab_BSC.Size = new System.Drawing.Size(220, 40);
            this.tab_BSC.TabIndex = 0;
            this.tab_BSC.TitleBoxValue = "Base Control Station";
            // 
            // BasePanel
            // 
            this.BasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BasePanel.Controls.Add(this.SSH_Panel);
            this.BasePanel.Controls.Add(this.GC_Panel);
            this.BasePanel.Controls.Add(this.ABT_Panel);
            this.BasePanel.Controls.Add(this.IC_Panel);
            this.BasePanel.Controls.Add(this.BSC_Panel);
            this.BasePanel.Controls.Add(this.MCS_Panel);
            this.BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasePanel.Location = new System.Drawing.Point(0, 0);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(844, 206);
            this.BasePanel.TabIndex = 7;
            this.BasePanel.Resize += new System.EventHandler(this.BasePanel_Resize);
            // 
            // SSH_Panel
            // 
            this.SSH_Panel.AutoScroll = true;
            this.SSH_Panel.BackColor = System.Drawing.Color.Black;
            this.SSH_Panel.Controls.Add(this.panel20);
            this.SSH_Panel.Controls.Add(this.panel19);
            this.SSH_Panel.Controls.Add(this.CMDLists);
            this.SSH_Panel.Controls.Add(this.SSHCMDLine);
            this.SSH_Panel.Controls.Add(this.SSHDebug);
            this.SSH_Panel.Controls.Add(this.panel37);
            this.SSH_Panel.Controls.Add(this.vncLocation);
            this.SSH_Panel.Controls.Add(this.OpenVncViewerBtn);
            this.SSH_Panel.Controls.Add(this.ReloadPuttyBtn);
            this.SSH_Panel.Controls.Add(this.puttyLocation);
            this.SSH_Panel.Controls.Add(this.OpenPuttyBtn);
            this.SSH_Panel.Location = new System.Drawing.Point(314, 6);
            this.SSH_Panel.Name = "SSH_Panel";
            this.SSH_Panel.Size = new System.Drawing.Size(527, 154);
            this.SSH_Panel.TabIndex = 4;
            this.SSH_Panel.Visible = false;
            // 
            // panel20
            // 
            this.panel20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel20.BackColor = System.Drawing.Color.DarkRed;
            this.panel20.Location = new System.Drawing.Point(2, 27);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(635, 1);
            this.panel20.TabIndex = 14;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.Color.DarkRed;
            this.panel19.Location = new System.Drawing.Point(330, 28);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1, 50);
            this.panel19.TabIndex = 13;
            // 
            // CMDLists
            // 
            this.CMDLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMDLists.BackColor = System.Drawing.Color.Black;
            this.CMDLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CMDLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDLists.ForeColor = System.Drawing.Color.Green;
            this.CMDLists.FormattingEnabled = true;
            this.CMDLists.Items.AddRange(new object[] {
            "k",
            "Kill",
            "ps aux | grep -i python",
            "python suz/ServerCore/Main.py"});
            this.CMDLists.Location = new System.Drawing.Point(331, 29);
            this.CMDLists.Name = "CMDLists";
            this.CMDLists.Size = new System.Drawing.Size(309, 39);
            this.CMDLists.Sorted = true;
            this.CMDLists.TabIndex = 12;
            this.CMDLists.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CMDLists_MouseDoubleClick);
            // 
            // SSHCMDLine
            // 
            this.SSHCMDLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SSHCMDLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SSHCMDLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SSHCMDLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSHCMDLine.ForeColor = System.Drawing.Color.White;
            this.SSHCMDLine.Location = new System.Drawing.Point(0, 79);
            this.SSHCMDLine.Name = "SSHCMDLine";
            this.SSHCMDLine.Size = new System.Drawing.Size(585, 22);
            this.SSHCMDLine.TabIndex = 11;
            this.SSHCMDLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SSHCMDLine_KeyDown);
            // 
            // SSHDebug
            // 
            this.SSHDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SSHDebug.BackColor = System.Drawing.Color.Black;
            this.SSHDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SSHDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSHDebug.ForeColor = System.Drawing.Color.White;
            this.SSHDebug.Location = new System.Drawing.Point(3, 32);
            this.SSHDebug.Name = "SSHDebug";
            this.SSHDebug.ReadOnly = true;
            this.SSHDebug.Size = new System.Drawing.Size(325, 41);
            this.SSHDebug.TabIndex = 10;
            this.SSHDebug.Text = "READY TO USE SSH(Secure Shell) using SSH.NET Library";
            // 
            // panel37
            // 
            this.panel37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.panel37.Controls.Add(this.SSH_reset);
            this.panel37.Controls.Add(this.SSH_Save);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel37.Location = new System.Drawing.Point(0, 101);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(585, 36);
            this.panel37.TabIndex = 9;
            // 
            // SSH_reset
            // 
            this.SSH_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SSH_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.SSH_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SSH_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSH_reset.ForeColor = System.Drawing.Color.Black;
            this.SSH_reset.Location = new System.Drawing.Point(428, 4);
            this.SSH_reset.Name = "SSH_reset";
            this.SSH_reset.Size = new System.Drawing.Size(74, 30);
            this.SSH_reset.TabIndex = 1;
            this.SSH_reset.Text = "Reset";
            this.SSH_reset.UseVisualStyleBackColor = false;
            this.SSH_reset.Click += new System.EventHandler(this.SSH_reset_Click);
            // 
            // SSH_Save
            // 
            this.SSH_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SSH_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.SSH_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SSH_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSH_Save.ForeColor = System.Drawing.Color.Black;
            this.SSH_Save.Location = new System.Drawing.Point(508, 4);
            this.SSH_Save.Name = "SSH_Save";
            this.SSH_Save.Size = new System.Drawing.Size(74, 30);
            this.SSH_Save.TabIndex = 0;
            this.SSH_Save.Text = "Save";
            this.SSH_Save.UseVisualStyleBackColor = false;
            this.SSH_Save.Click += new System.EventHandler(this.SSH_Save_Click);
            // 
            // vncLocation
            // 
            this.vncLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.vncLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vncLocation.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vncLocation.Location = new System.Drawing.Point(377, 3);
            this.vncLocation.Name = "vncLocation";
            this.vncLocation.Size = new System.Drawing.Size(175, 21);
            this.vncLocation.TabIndex = 7;
            // 
            // OpenVncViewerBtn
            // 
            this.OpenVncViewerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.OpenVncViewerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenVncViewerBtn.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenVncViewerBtn.ForeColor = System.Drawing.Color.Black;
            this.OpenVncViewerBtn.Location = new System.Drawing.Point(260, 1);
            this.OpenVncViewerBtn.Name = "OpenVncViewerBtn";
            this.OpenVncViewerBtn.Size = new System.Drawing.Size(113, 24);
            this.OpenVncViewerBtn.TabIndex = 5;
            this.OpenVncViewerBtn.Text = "Open VNC Viewer";
            this.OpenVncViewerBtn.UseVisualStyleBackColor = false;
            this.OpenVncViewerBtn.Click += new System.EventHandler(this.OpenVncViewerBtn_Click);
            // 
            // ReloadPuttyBtn
            // 
            this.ReloadPuttyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ReloadPuttyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReloadPuttyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadPuttyBtn.ForeColor = System.Drawing.Color.Black;
            this.ReloadPuttyBtn.Image = global::PIDrone.Properties.Resources.reset;
            this.ReloadPuttyBtn.Location = new System.Drawing.Point(558, 3);
            this.ReloadPuttyBtn.Name = "ReloadPuttyBtn";
            this.ReloadPuttyBtn.Size = new System.Drawing.Size(27, 22);
            this.ReloadPuttyBtn.TabIndex = 4;
            this.ReloadPuttyBtn.UseVisualStyleBackColor = false;
            this.ReloadPuttyBtn.Click += new System.EventHandler(this.ReloadPuttyBtn_Click);
            // 
            // puttyLocation
            // 
            this.puttyLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.puttyLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puttyLocation.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puttyLocation.Location = new System.Drawing.Point(83, 3);
            this.puttyLocation.Name = "puttyLocation";
            this.puttyLocation.Size = new System.Drawing.Size(163, 21);
            this.puttyLocation.TabIndex = 3;
            // 
            // OpenPuttyBtn
            // 
            this.OpenPuttyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.OpenPuttyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPuttyBtn.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPuttyBtn.ForeColor = System.Drawing.Color.Black;
            this.OpenPuttyBtn.Location = new System.Drawing.Point(4, 0);
            this.OpenPuttyBtn.Name = "OpenPuttyBtn";
            this.OpenPuttyBtn.Size = new System.Drawing.Size(73, 25);
            this.OpenPuttyBtn.TabIndex = 1;
            this.OpenPuttyBtn.Text = "Open Putty";
            this.OpenPuttyBtn.UseVisualStyleBackColor = false;
            this.OpenPuttyBtn.Click += new System.EventHandler(this.OpenPuttyBtn_Click);
            // 
            // GC_Panel
            // 
            this.GC_Panel.AutoScroll = true;
            this.GC_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GC_Panel.Controls.Add(this.panel18);
            this.GC_Panel.Controls.Add(this.panel1);
            this.GC_Panel.Controls.Add(this.panel35);
            this.GC_Panel.Controls.Add(this.panel6);
            this.GC_Panel.Controls.Add(this.label4);
            this.GC_Panel.Location = new System.Drawing.Point(7, 75);
            this.GC_Panel.Name = "GC_Panel";
            this.GC_Panel.Size = new System.Drawing.Size(105, 74);
            this.GC_Panel.TabIndex = 3;
            this.GC_Panel.Visible = false;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(164)))));
            this.panel18.Controls.Add(this.label43);
            this.panel18.Controls.Add(this.gc_DIP);
            this.panel18.Controls.Add(this.label49);
            this.panel18.Controls.Add(this.gc_IP);
            this.panel18.Controls.Add(this.label50);
            this.panel18.Controls.Add(this.label52);
            this.panel18.Controls.Add(this.gc_CP);
            this.panel18.Controls.Add(this.gc_SP);
            this.panel18.Controls.Add(this.label51);
            this.panel18.Location = new System.Drawing.Point(308, 28);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(229, 130);
            this.panel18.TabIndex = 17;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(3, 3);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(80, 13);
            this.label43.TabIndex = 8;
            this.label43.Text = "Drone IP && Port";
            // 
            // gc_DIP
            // 
            this.gc_DIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.gc_DIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gc_DIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_DIP.Location = new System.Drawing.Point(116, 17);
            this.gc_DIP.Name = "gc_DIP";
            this.gc_DIP.Size = new System.Drawing.Size(91, 21);
            this.gc_DIP.TabIndex = 8;
            this.gc_DIP.Text = "127.0.0.1";
            this.gc_DIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(20, 21);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(90, 13);
            this.label49.TabIndex = 7;
            this.label49.Text = "Drone IP Address";
            // 
            // gc_IP
            // 
            this.gc_IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.gc_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gc_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_IP.Location = new System.Drawing.Point(116, 101);
            this.gc_IP.Name = "gc_IP";
            this.gc_IP.Size = new System.Drawing.Size(91, 21);
            this.gc_IP.TabIndex = 14;
            this.gc_IP.Text = "8002";
            this.gc_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(48, 48);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(62, 13);
            this.label50.TabIndex = 9;
            this.label50.Text = "Control Port";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(51, 105);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(58, 13);
            this.label52.TabIndex = 13;
            this.label52.Text = "Image Port";
            // 
            // gc_CP
            // 
            this.gc_CP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.gc_CP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gc_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_CP.Location = new System.Drawing.Point(116, 44);
            this.gc_CP.Name = "gc_CP";
            this.gc_CP.Size = new System.Drawing.Size(91, 21);
            this.gc_CP.TabIndex = 10;
            this.gc_CP.Text = "8000";
            this.gc_CP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gc_SP
            // 
            this.gc_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(170)))));
            this.gc_SP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gc_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_SP.Location = new System.Drawing.Point(116, 73);
            this.gc_SP.Name = "gc_SP";
            this.gc_SP.Size = new System.Drawing.Size(91, 21);
            this.gc_SP.TabIndex = 12;
            this.gc_SP.Text = "8001";
            this.gc_SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(51, 77);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(59, 13);
            this.label51.TabIndex = 11;
            this.label51.Text = "Status Port";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.wifiList);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 130);
            this.panel1.TabIndex = 16;
            // 
            // wifiList
            // 
            this.wifiList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(164)))));
            this.wifiList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wifiList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifiList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.wifiList.FormattingEnabled = true;
            this.wifiList.ItemHeight = 15;
            this.wifiList.Location = new System.Drawing.Point(8, 18);
            this.wifiList.Name = "wifiList";
            this.wifiList.Size = new System.Drawing.Size(286, 105);
            this.wifiList.TabIndex = 10;
            this.wifiList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.wifiList_MouseDoubleClick);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(2, 3);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(95, 13);
            this.label44.TabIndex = 9;
            this.label44.Text = "WIFI Access Point";
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel35.Controls.Add(this.generalConfigReset);
            this.panel35.Controls.Add(this.generalConfigSave);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel35.Location = new System.Drawing.Point(0, 158);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(537, 36);
            this.panel35.TabIndex = 6;
            // 
            // generalConfigReset
            // 
            this.generalConfigReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalConfigReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.generalConfigReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generalConfigReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalConfigReset.ForeColor = System.Drawing.Color.Black;
            this.generalConfigReset.Location = new System.Drawing.Point(380, 4);
            this.generalConfigReset.Name = "generalConfigReset";
            this.generalConfigReset.Size = new System.Drawing.Size(74, 30);
            this.generalConfigReset.TabIndex = 1;
            this.generalConfigReset.Text = "Reset";
            this.generalConfigReset.UseVisualStyleBackColor = false;
            this.generalConfigReset.Click += new System.EventHandler(this.generalConfigReset_Click);
            // 
            // generalConfigSave
            // 
            this.generalConfigSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generalConfigSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(72)))));
            this.generalConfigSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generalConfigSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generalConfigSave.ForeColor = System.Drawing.Color.Black;
            this.generalConfigSave.Location = new System.Drawing.Point(460, 4);
            this.generalConfigSave.Name = "generalConfigSave";
            this.generalConfigSave.Size = new System.Drawing.Size(74, 30);
            this.generalConfigSave.TabIndex = 0;
            this.generalConfigSave.Text = "Save";
            this.generalConfigSave.UseVisualStyleBackColor = false;
            this.generalConfigSave.Click += new System.EventHandler(this.generalConfigSave_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(6, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3749, 1);
            this.panel6.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "General Configuration";
            // 
            // ABT_Panel
            // 
            this.ABT_Panel.AutoScroll = true;
            this.ABT_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.ABT_Panel.Controls.Add(this.label42);
            this.ABT_Panel.Controls.Add(this.label37);
            this.ABT_Panel.ForeColor = System.Drawing.Color.Black;
            this.ABT_Panel.Location = new System.Drawing.Point(114, 75);
            this.ABT_Panel.Name = "ABT_Panel";
            this.ABT_Panel.Size = new System.Drawing.Size(81, 79);
            this.ABT_Panel.TabIndex = 5;
            this.ABT_Panel.Visible = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(20, 24);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(60, 13);
            this.label42.TabIndex = 1;
            this.label42.Text = "Version 1.0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 6);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(89, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "PI Control Station";
            // 
            // IC_Panel
            // 
            this.IC_Panel.AutoScroll = true;
            this.IC_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.IC_Panel.Controls.Add(this.panel10);
            this.IC_Panel.Controls.Add(this.panel29);
            this.IC_Panel.Controls.Add(this.label2);
            this.IC_Panel.Location = new System.Drawing.Point(200, 76);
            this.IC_Panel.Name = "IC_Panel";
            this.IC_Panel.Size = new System.Drawing.Size(109, 83);
            this.IC_Panel.TabIndex = 1;
            this.IC_Panel.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(109, 47);
            this.panel10.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel11.Location = new System.Drawing.Point(2, 169);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(252, 2);
            this.panel11.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Input Control";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(167)))), ((int)(((byte)(224)))));
            this.panel12.Controls.Add(this.flowLayoutPanel1);
            this.panel12.Controls.Add(this.label31);
            this.panel12.ForeColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(2, 18);
            this.panel12.MaximumSize = new System.Drawing.Size(800, 150);
            this.panel12.MinimumSize = new System.Drawing.Size(485, 150);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(485, 150);
            this.panel12.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.label25);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel7);
            this.flowLayoutPanel1.Controls.Add(this.label28);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(485, 135);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rudder Trim System";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel13, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel22, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 21);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(189, 38);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.Rmin);
            this.panel13.Controls.Add(this.label9);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(97, 3);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(5);
            this.panel13.Size = new System.Drawing.Size(89, 32);
            this.panel13.TabIndex = 2;
            // 
            // Rmin
            // 
            this.Rmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rmin.Location = new System.Drawing.Point(35, 5);
            this.Rmin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Rmin.Name = "Rmin";
            this.Rmin.Size = new System.Drawing.Size(49, 20);
            this.Rmin.TabIndex = 0;
            this.Rmin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "MIN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.Rmax);
            this.panel22.Controls.Add(this.label10);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(3, 3);
            this.panel22.Name = "panel22";
            this.panel22.Padding = new System.Windows.Forms.Padding(5);
            this.panel22.Size = new System.Drawing.Size(88, 32);
            this.panel22.TabIndex = 1;
            // 
            // Rmax
            // 
            this.Rmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rmax.Location = new System.Drawing.Point(35, 5);
            this.Rmax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Rmax.Name = "Rmax";
            this.Rmax.Size = new System.Drawing.Size(48, 20);
            this.Rmax.TabIndex = 0;
            this.Rmax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "MAX";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Aileron Trim System";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.panel23, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel24, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 78);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(189, 38);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.Amin);
            this.panel23.Controls.Add(this.label12);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(97, 3);
            this.panel23.Name = "panel23";
            this.panel23.Padding = new System.Windows.Forms.Padding(5);
            this.panel23.Size = new System.Drawing.Size(89, 32);
            this.panel23.TabIndex = 2;
            // 
            // Amin
            // 
            this.Amin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amin.Location = new System.Drawing.Point(35, 5);
            this.Amin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Amin.Name = "Amin";
            this.Amin.Size = new System.Drawing.Size(49, 20);
            this.Amin.TabIndex = 0;
            this.Amin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(5, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "MIN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.Amax);
            this.panel24.Controls.Add(this.label13);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(3, 3);
            this.panel24.Name = "panel24";
            this.panel24.Padding = new System.Windows.Forms.Padding(5);
            this.panel24.Size = new System.Drawing.Size(88, 32);
            this.panel24.TabIndex = 1;
            // 
            // Amax
            // 
            this.Amax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Amax.Location = new System.Drawing.Point(35, 5);
            this.Amax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Amax.Name = "Amax";
            this.Amax.Size = new System.Drawing.Size(48, 20);
            this.Amax.TabIndex = 0;
            this.Amax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Location = new System.Drawing.Point(5, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 22);
            this.label13.TabIndex = 1;
            this.label13.Text = "MAX";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(203, 5);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Throttle Trim System";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.panel25, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel26, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(203, 21);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(189, 38);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.Tmin);
            this.panel25.Controls.Add(this.label26);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(97, 3);
            this.panel25.Name = "panel25";
            this.panel25.Padding = new System.Windows.Forms.Padding(5);
            this.panel25.Size = new System.Drawing.Size(89, 32);
            this.panel25.TabIndex = 2;
            // 
            // Tmin
            // 
            this.Tmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tmin.Location = new System.Drawing.Point(35, 5);
            this.Tmin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Tmin.Name = "Tmin";
            this.Tmin.Size = new System.Drawing.Size(49, 20);
            this.Tmin.TabIndex = 0;
            this.Tmin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Left;
            this.label26.Location = new System.Drawing.Point(5, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 22);
            this.label26.TabIndex = 1;
            this.label26.Text = "MIN";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.Tmax);
            this.panel26.Controls.Add(this.label27);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(3, 3);
            this.panel26.Name = "panel26";
            this.panel26.Padding = new System.Windows.Forms.Padding(5);
            this.panel26.Size = new System.Drawing.Size(88, 32);
            this.panel26.TabIndex = 1;
            // 
            // Tmax
            // 
            this.Tmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tmax.Location = new System.Drawing.Point(35, 5);
            this.Tmax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Tmax.Name = "Tmax";
            this.Tmax.Size = new System.Drawing.Size(48, 20);
            this.Tmax.TabIndex = 0;
            this.Tmax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.Dock = System.Windows.Forms.DockStyle.Left;
            this.label27.Location = new System.Drawing.Point(5, 5);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 22);
            this.label27.TabIndex = 1;
            this.label27.Text = "MAX";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(203, 62);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "Elevator Trim System";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.panel27, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel28, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(203, 78);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(189, 38);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.Emin);
            this.panel27.Controls.Add(this.label29);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(97, 3);
            this.panel27.Name = "panel27";
            this.panel27.Padding = new System.Windows.Forms.Padding(5);
            this.panel27.Size = new System.Drawing.Size(89, 32);
            this.panel27.TabIndex = 2;
            // 
            // Emin
            // 
            this.Emin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emin.Location = new System.Drawing.Point(35, 5);
            this.Emin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Emin.Name = "Emin";
            this.Emin.Size = new System.Drawing.Size(49, 20);
            this.Emin.TabIndex = 0;
            this.Emin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.Dock = System.Windows.Forms.DockStyle.Left;
            this.label29.Location = new System.Drawing.Point(5, 5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 22);
            this.label29.TabIndex = 1;
            this.label29.Text = "MIN";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.Emax);
            this.panel28.Controls.Add(this.label30);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(3, 3);
            this.panel28.Name = "panel28";
            this.panel28.Padding = new System.Windows.Forms.Padding(5);
            this.panel28.Size = new System.Drawing.Size(88, 32);
            this.panel28.TabIndex = 1;
            // 
            // Emax
            // 
            this.Emax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Emax.Location = new System.Drawing.Point(35, 5);
            this.Emax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Emax.Name = "Emax";
            this.Emax.Size = new System.Drawing.Size(48, 20);
            this.Emax.TabIndex = 0;
            this.Emax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label30
            // 
            this.label30.Dock = System.Windows.Forms.DockStyle.Left;
            this.label30.Location = new System.Drawing.Point(5, 5);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 22);
            this.label30.TabIndex = 1;
            this.label30.Text = "MAX";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aux Range";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel16, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel15, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel17, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(398, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(330, 35);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.Aux_low);
            this.panel16.Controls.Add(this.label40);
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(5);
            this.panel16.Size = new System.Drawing.Size(103, 29);
            this.panel16.TabIndex = 3;
            // 
            // Aux_low
            // 
            this.Aux_low.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Aux_low.Location = new System.Drawing.Point(42, 5);
            this.Aux_low.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Aux_low.Name = "Aux_low";
            this.Aux_low.Size = new System.Drawing.Size(56, 20);
            this.Aux_low.TabIndex = 0;
            this.Aux_low.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label40
            // 
            this.label40.Dock = System.Windows.Forms.DockStyle.Left;
            this.label40.Location = new System.Drawing.Point(5, 5);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(37, 19);
            this.label40.TabIndex = 1;
            this.label40.Text = "LOW";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.Aux_mid);
            this.panel15.Controls.Add(this.label39);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(113, 3);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(5);
            this.panel15.Size = new System.Drawing.Size(104, 29);
            this.panel15.TabIndex = 2;
            // 
            // Aux_mid
            // 
            this.Aux_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Aux_mid.Location = new System.Drawing.Point(42, 5);
            this.Aux_mid.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Aux_mid.Name = "Aux_mid";
            this.Aux_mid.Size = new System.Drawing.Size(57, 20);
            this.Aux_mid.TabIndex = 0;
            this.Aux_mid.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // label39
            // 
            this.label39.Dock = System.Windows.Forms.DockStyle.Left;
            this.label39.Location = new System.Drawing.Point(5, 5);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(37, 19);
            this.label39.TabIndex = 1;
            this.label39.Text = "MID";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.Aux_high);
            this.panel17.Controls.Add(this.label41);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(223, 3);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(5);
            this.panel17.Size = new System.Drawing.Size(104, 29);
            this.panel17.TabIndex = 4;
            // 
            // Aux_high
            // 
            this.Aux_high.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Aux_high.Location = new System.Drawing.Point(42, 5);
            this.Aux_high.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Aux_high.Name = "Aux_high";
            this.Aux_high.Size = new System.Drawing.Size(57, 20);
            this.Aux_high.TabIndex = 0;
            this.Aux_high.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label41
            // 
            this.label41.Dock = System.Windows.Forms.DockStyle.Left;
            this.label41.Location = new System.Drawing.Point(5, 5);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(37, 19);
            this.label41.TabIndex = 1;
            this.label41.Text = "HIGH";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Top;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(0, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(105, 15);
            this.label31.TabIndex = 0;
            this.label31.Text = "Input Trim System";
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(160)))), ((int)(((byte)(222)))));
            this.panel29.Controls.Add(this.Input_ResetBtn);
            this.panel29.Controls.Add(this.Input_SaveBtn);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel29.Location = new System.Drawing.Point(0, 47);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(109, 36);
            this.panel29.TabIndex = 5;
            // 
            // Input_ResetBtn
            // 
            this.Input_ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.Input_ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Input_ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Input_ResetBtn.ForeColor = System.Drawing.Color.Black;
            this.Input_ResetBtn.Location = new System.Drawing.Point(-48, 4);
            this.Input_ResetBtn.Name = "Input_ResetBtn";
            this.Input_ResetBtn.Size = new System.Drawing.Size(74, 30);
            this.Input_ResetBtn.TabIndex = 1;
            this.Input_ResetBtn.Text = "Reset";
            this.Input_ResetBtn.UseVisualStyleBackColor = false;
            this.Input_ResetBtn.Click += new System.EventHandler(this.Input_ResetBtn_Click);
            // 
            // Input_SaveBtn
            // 
            this.Input_SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Input_SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Input_SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Input_SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Input_SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.Input_SaveBtn.Location = new System.Drawing.Point(32, 4);
            this.Input_SaveBtn.Name = "Input_SaveBtn";
            this.Input_SaveBtn.Size = new System.Drawing.Size(74, 30);
            this.Input_SaveBtn.TabIndex = 0;
            this.Input_SaveBtn.Text = "Save";
            this.Input_SaveBtn.UseVisualStyleBackColor = false;
            this.Input_SaveBtn.Click += new System.EventHandler(this.Input_SaveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Control";
            // 
            // BSC_Panel
            // 
            this.BSC_Panel.AutoScroll = true;
            this.BSC_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BSC_Panel.Controls.Add(this.panel7);
            this.BSC_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSC_Panel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BSC_Panel.Location = new System.Drawing.Point(4, 6);
            this.BSC_Panel.Name = "BSC_Panel";
            this.BSC_Panel.Size = new System.Drawing.Size(150, 66);
            this.BSC_Panel.TabIndex = 0;
            this.BSC_Panel.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BStationLable);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 66);
            this.panel7.TabIndex = 2;
            // 
            // BStationLable
            // 
            this.BStationLable.AutoSize = true;
            this.BStationLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.BStationLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BStationLable.ForeColor = System.Drawing.Color.White;
            this.BStationLable.Location = new System.Drawing.Point(0, 0);
            this.BStationLable.Name = "BStationLable";
            this.BStationLable.Size = new System.Drawing.Size(118, 15);
            this.BStationLable.TabIndex = 2;
            this.BStationLable.Text = "Base Control Station";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(213)))), ((int)(((byte)(176)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(3, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 45);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 43);
            this.panel3.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(157)))));
            this.panel14.Controls.Add(this.UPad);
            this.panel14.Controls.Add(this.LPad);
            this.panel14.Controls.Add(this.DPad);
            this.panel14.Controls.Add(this.RPad);
            this.panel14.Controls.Add(this.pictureBox1);
            this.panel14.Controls.Add(this.label58);
            this.panel14.Location = new System.Drawing.Point(544, 23);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(118, 115);
            this.panel14.TabIndex = 4;
            // 
            // UPad
            // 
            this.UPad.BackColor = System.Drawing.Color.White;
            this.UPad.Image = ((System.Drawing.Image)(resources.GetObject("UPad.Image")));
            this.UPad.Location = new System.Drawing.Point(52, 24);
            this.UPad.Name = "UPad";
            this.UPad.Padding = new System.Windows.Forms.Padding(2);
            this.UPad.Size = new System.Drawing.Size(15, 15);
            this.UPad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UPad.TabIndex = 8;
            this.UPad.TabStop = false;
            this.UPad.Visible = false;
            // 
            // LPad
            // 
            this.LPad.BackColor = System.Drawing.Color.White;
            this.LPad.Image = ((System.Drawing.Image)(resources.GetObject("LPad.Image")));
            this.LPad.Location = new System.Drawing.Point(16, 61);
            this.LPad.Name = "LPad";
            this.LPad.Padding = new System.Windows.Forms.Padding(2);
            this.LPad.Size = new System.Drawing.Size(15, 15);
            this.LPad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LPad.TabIndex = 7;
            this.LPad.TabStop = false;
            this.LPad.Visible = false;
            // 
            // DPad
            // 
            this.DPad.BackColor = System.Drawing.Color.White;
            this.DPad.Image = ((System.Drawing.Image)(resources.GetObject("DPad.Image")));
            this.DPad.Location = new System.Drawing.Point(52, 95);
            this.DPad.Name = "DPad";
            this.DPad.Padding = new System.Windows.Forms.Padding(2);
            this.DPad.Size = new System.Drawing.Size(15, 15);
            this.DPad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DPad.TabIndex = 6;
            this.DPad.TabStop = false;
            this.DPad.Visible = false;
            // 
            // RPad
            // 
            this.RPad.BackColor = System.Drawing.Color.White;
            this.RPad.Image = ((System.Drawing.Image)(resources.GetObject("RPad.Image")));
            this.RPad.Location = new System.Drawing.Point(86, 61);
            this.RPad.Name = "RPad";
            this.RPad.Padding = new System.Windows.Forms.Padding(2);
            this.RPad.Size = new System.Drawing.Size(15, 15);
            this.RPad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RPad.TabIndex = 5;
            this.RPad.TabStop = false;
            this.RPad.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIDrone.Properties.Resources.dCircle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(4, 3);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(101, 15);
            this.label58.TabIndex = 1;
            this.label58.Text = "Point Of View Hat";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(157)))));
            this.panel9.Controls.Add(this.BtnAB2);
            this.panel9.Controls.Add(this.BtnAB1);
            this.panel9.Controls.Add(this.BtnBack);
            this.panel9.Controls.Add(this.BtnStart);
            this.panel9.Controls.Add(this.BtnLB);
            this.panel9.Controls.Add(this.BtnRB);
            this.panel9.Controls.Add(this.BtnA);
            this.panel9.Controls.Add(this.BtnB);
            this.panel9.Controls.Add(this.BtnY);
            this.panel9.Controls.Add(this.BtnX);
            this.panel9.Controls.Add(this.label35);
            this.panel9.Controls.Add(this.label36);
            this.panel9.Controls.Add(this.label24);
            this.panel9.Controls.Add(this.label32);
            this.panel9.Controls.Add(this.label33);
            this.panel9.Controls.Add(this.label34);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.label20);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Controls.Add(this.label22);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(275, 23);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(268, 115);
            this.panel9.TabIndex = 3;
            // 
            // BtnAB2
            // 
            this.BtnAB2.AutoSize = true;
            this.BtnAB2.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAB2.ForeColor = System.Drawing.Color.Maroon;
            this.BtnAB2.Location = new System.Drawing.Point(222, 45);
            this.BtnAB2.Name = "BtnAB2";
            this.BtnAB2.Size = new System.Drawing.Size(37, 15);
            this.BtnAB2.TabIndex = 23;
            this.BtnAB2.Text = "False";
            // 
            // BtnAB1
            // 
            this.BtnAB1.AutoSize = true;
            this.BtnAB1.ForeColor = System.Drawing.Color.Maroon;
            this.BtnAB1.Location = new System.Drawing.Point(221, 27);
            this.BtnAB1.Name = "BtnAB1";
            this.BtnAB1.Size = new System.Drawing.Size(37, 15);
            this.BtnAB1.TabIndex = 22;
            this.BtnAB1.Text = "False";
            // 
            // BtnBack
            // 
            this.BtnBack.AutoSize = true;
            this.BtnBack.ForeColor = System.Drawing.Color.Maroon;
            this.BtnBack.Location = new System.Drawing.Point(105, 79);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(37, 15);
            this.BtnBack.TabIndex = 21;
            this.BtnBack.Text = "False";
            // 
            // BtnStart
            // 
            this.BtnStart.AutoSize = true;
            this.BtnStart.ForeColor = System.Drawing.Color.Maroon;
            this.BtnStart.Location = new System.Drawing.Point(104, 62);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(37, 15);
            this.BtnStart.TabIndex = 20;
            this.BtnStart.Text = "False";
            // 
            // BtnLB
            // 
            this.BtnLB.AutoSize = true;
            this.BtnLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnLB.ForeColor = System.Drawing.Color.Maroon;
            this.BtnLB.Location = new System.Drawing.Point(104, 45);
            this.BtnLB.Name = "BtnLB";
            this.BtnLB.Size = new System.Drawing.Size(37, 15);
            this.BtnLB.TabIndex = 19;
            this.BtnLB.Text = "False";
            // 
            // BtnRB
            // 
            this.BtnRB.AutoSize = true;
            this.BtnRB.ForeColor = System.Drawing.Color.Maroon;
            this.BtnRB.Location = new System.Drawing.Point(103, 28);
            this.BtnRB.Name = "BtnRB";
            this.BtnRB.Size = new System.Drawing.Size(37, 15);
            this.BtnRB.TabIndex = 18;
            this.BtnRB.Text = "False";
            // 
            // BtnA
            // 
            this.BtnA.AutoSize = true;
            this.BtnA.ForeColor = System.Drawing.Color.Maroon;
            this.BtnA.Location = new System.Drawing.Point(28, 62);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(37, 15);
            this.BtnA.TabIndex = 17;
            this.BtnA.Text = "False";
            // 
            // BtnB
            // 
            this.BtnB.AutoSize = true;
            this.BtnB.ForeColor = System.Drawing.Color.Maroon;
            this.BtnB.Location = new System.Drawing.Point(28, 80);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(37, 15);
            this.BtnB.TabIndex = 16;
            this.BtnB.Text = "False";
            // 
            // BtnY
            // 
            this.BtnY.AutoSize = true;
            this.BtnY.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnY.ForeColor = System.Drawing.Color.Maroon;
            this.BtnY.Location = new System.Drawing.Point(29, 43);
            this.BtnY.Name = "BtnY";
            this.BtnY.Size = new System.Drawing.Size(37, 15);
            this.BtnY.TabIndex = 15;
            this.BtnY.Text = "False";
            // 
            // BtnX
            // 
            this.BtnX.AutoSize = true;
            this.BtnX.ForeColor = System.Drawing.Color.Maroon;
            this.BtnX.Location = new System.Drawing.Point(28, 26);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(37, 15);
            this.BtnX.TabIndex = 14;
            this.BtnX.Text = "False";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(150, 45);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(73, 15);
            this.label35.TabIndex = 13;
            this.label35.Text = "AnalogBtn 2";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(150, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(73, 15);
            this.label36.TabIndex = 12;
            this.label36.Text = "AnalogBtn 1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(74, 79);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 15);
            this.label24.TabIndex = 11;
            this.label24.Text = "Back";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(74, 62);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 15);
            this.label32.TabIndex = 10;
            this.label32.Text = "Start";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Cursor = System.Windows.Forms.Cursors.Default;
            this.label33.Location = new System.Drawing.Point(74, 45);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(22, 15);
            this.label33.TabIndex = 9;
            this.label33.Text = "LB";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(73, 28);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(24, 15);
            this.label34.TabIndex = 8;
            this.label34.Text = "RB";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 15);
            this.label23.TabIndex = 7;
            this.label23.Text = "A";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 15);
            this.label20.TabIndex = 6;
            this.label20.Text = "B";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Location = new System.Drawing.Point(16, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 15);
            this.label21.TabIndex = 5;
            this.label21.Text = "Y";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 15);
            this.label22.TabIndex = 4;
            this.label22.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Buttons";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(157)))));
            this.panel8.Controls.Add(this.AxesTrigger);
            this.panel8.Controls.Add(this.label38);
            this.panel8.Controls.Add(this.TAxisR);
            this.panel8.Controls.Add(this.label55);
            this.panel8.Controls.Add(this.YRotation);
            this.panel8.Controls.Add(this.XRotation);
            this.panel8.Controls.Add(this.TAxisL);
            this.panel8.Controls.Add(this.YAxis);
            this.panel8.Controls.Add(this.XAxis);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(4, 23);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 115);
            this.panel8.TabIndex = 2;
            // 
            // AxesTrigger
            // 
            this.AxesTrigger.AutoSize = true;
            this.AxesTrigger.ForeColor = System.Drawing.Color.Maroon;
            this.AxesTrigger.Location = new System.Drawing.Point(119, 97);
            this.AxesTrigger.Name = "AxesTrigger";
            this.AxesTrigger.Size = new System.Drawing.Size(31, 15);
            this.AxesTrigger.TabIndex = 25;
            this.AxesTrigger.Text = "0.00";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 97);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(77, 15);
            this.label38.TabIndex = 24;
            this.label38.Text = "Trigger Axis :";
            // 
            // TAxisR
            // 
            this.TAxisR.AutoSize = true;
            this.TAxisR.ForeColor = System.Drawing.Color.Maroon;
            this.TAxisR.Location = new System.Drawing.Point(119, 80);
            this.TAxisR.Name = "TAxisR";
            this.TAxisR.Size = new System.Drawing.Size(31, 15);
            this.TAxisR.TabIndex = 23;
            this.TAxisR.Text = "0.00";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(12, 80);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(106, 15);
            this.label55.TabIndex = 22;
            this.label55.Text = "Trigger Axis Right:";
            // 
            // YRotation
            // 
            this.YRotation.AutoSize = true;
            this.YRotation.Cursor = System.Windows.Forms.Cursors.Default;
            this.YRotation.ForeColor = System.Drawing.Color.Maroon;
            this.YRotation.Location = new System.Drawing.Point(196, 46);
            this.YRotation.Name = "YRotation";
            this.YRotation.Size = new System.Drawing.Size(31, 15);
            this.YRotation.TabIndex = 21;
            this.YRotation.Text = "0.00";
            // 
            // XRotation
            // 
            this.XRotation.AutoSize = true;
            this.XRotation.ForeColor = System.Drawing.Color.Maroon;
            this.XRotation.Location = new System.Drawing.Point(196, 26);
            this.XRotation.Name = "XRotation";
            this.XRotation.Size = new System.Drawing.Size(31, 15);
            this.XRotation.TabIndex = 20;
            this.XRotation.Text = "0.00";
            // 
            // TAxisL
            // 
            this.TAxisL.AutoSize = true;
            this.TAxisL.ForeColor = System.Drawing.Color.Maroon;
            this.TAxisL.Location = new System.Drawing.Point(119, 63);
            this.TAxisL.Name = "TAxisL";
            this.TAxisL.Size = new System.Drawing.Size(31, 15);
            this.TAxisL.TabIndex = 19;
            this.TAxisL.Text = "0.00";
            // 
            // YAxis
            // 
            this.YAxis.AutoSize = true;
            this.YAxis.Cursor = System.Windows.Forms.Cursors.Default;
            this.YAxis.ForeColor = System.Drawing.Color.Maroon;
            this.YAxis.Location = new System.Drawing.Point(59, 45);
            this.YAxis.Name = "YAxis";
            this.YAxis.Size = new System.Drawing.Size(31, 15);
            this.YAxis.TabIndex = 18;
            this.YAxis.Text = "0.00";
            // 
            // XAxis
            // 
            this.XAxis.AutoSize = true;
            this.XAxis.ForeColor = System.Drawing.Color.Maroon;
            this.XAxis.Location = new System.Drawing.Point(59, 26);
            this.XAxis.Name = "XAxis";
            this.XAxis.Size = new System.Drawing.Size(31, 15);
            this.XAxis.TabIndex = 17;
            this.XAxis.Text = "0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Location = new System.Drawing.Point(130, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Y Rotation:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(130, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 4;
            this.label19.Text = "X Rotation:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 15);
            this.label18.TabIndex = 3;
            this.label18.Text = "Trigger Axis Left:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Location = new System.Drawing.Point(12, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Y Axis :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "X Axis :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Axes && Point Of View Hat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Joystick Properties";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 2);
            this.panel2.TabIndex = 2;
            // 
            // MCS_Panel
            // 
            this.MCS_Panel.AutoScroll = true;
            this.MCS_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.MCS_Panel.Controls.Add(this.label3);
            this.MCS_Panel.Location = new System.Drawing.Point(157, 6);
            this.MCS_Panel.Name = "MCS_Panel";
            this.MCS_Panel.Size = new System.Drawing.Size(151, 68);
            this.MCS_Panel.TabIndex = 2;
            this.MCS_Panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.SkyBlue;
            this.panel31.Controls.Add(this.sContainer);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel31.Location = new System.Drawing.Point(220, 0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(844, 749);
            this.panel31.TabIndex = 8;
            // 
            // sContainer
            // 
            this.sContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainer.Location = new System.Drawing.Point(0, 0);
            this.sContainer.Name = "sContainer";
            this.sContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sContainer.Panel1
            // 
            this.sContainer.Panel1.Controls.Add(this.BackPanel);
            this.sContainer.Panel1MinSize = 300;
            // 
            // sContainer.Panel2
            // 
            this.sContainer.Panel2.Controls.Add(this.BasePanel);
            this.sContainer.Panel2MinSize = 205;
            this.sContainer.Size = new System.Drawing.Size(844, 749);
            this.sContainer.SplitterDistance = 541;
            this.sContainer.SplitterWidth = 2;
            this.sContainer.TabIndex = 10;
            this.sContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sContainer_SplitterMoved);
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.BackPanel.Controls.Add(this.DrawPanelBox);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(844, 541);
            this.BackPanel.TabIndex = 9;
            // 
            // DrawPanelBox
            // 
            this.DrawPanelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPanelBox.Location = new System.Drawing.Point(0, 0);
            this.DrawPanelBox.Name = "DrawPanelBox";
            this.DrawPanelBox.Size = new System.Drawing.Size(844, 541);
            this.DrawPanelBox.TabIndex = 8;
            // 
            // BorderPanel
            // 
            this.BorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderPanel.Location = new System.Drawing.Point(0, 239);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(727, 1);
            this.BorderPanel.TabIndex = 1;
            // 
            // JoystickTimer
            // 
            this.JoystickTimer.Tick += new System.EventHandler(this.JoystickTimer_Tick);
            // 
            // MessageBoxTimer
            // 
            this.MessageBoxTimer.Interval = 600;
            this.MessageBoxTimer.Tick += new System.EventHandler(this.MessageBoxTimer_Tick);
            // 
            // MainActivity
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1064, 771);
            this.Controls.Add(this.panel31);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.MainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1080, 800);
            this.Name = "MainActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI Control Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainActivity_FormClosing);
            this.Load += new System.EventHandler(this.MainActivity_Load);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.MsgPanel.ResumeLayout(false);
            this.BasePanel.ResumeLayout(false);
            this.SSH_Panel.ResumeLayout(false);
            this.SSH_Panel.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.GC_Panel.ResumeLayout(false);
            this.GC_Panel.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel35.ResumeLayout(false);
            this.ABT_Panel.ResumeLayout(false);
            this.ABT_Panel.PerformLayout();
            this.IC_Panel.ResumeLayout(false);
            this.IC_Panel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rmin)).EndInit();
            this.panel22.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rmax)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Amin)).EndInit();
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Amax)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tmin)).EndInit();
            this.panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tmax)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Emin)).EndInit();
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Emax)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Aux_low)).EndInit();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Aux_mid)).EndInit();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Aux_high)).EndInit();
            this.panel29.ResumeLayout(false);
            this.BSC_Panel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.MCS_Panel.ResumeLayout(false);
            this.MCS_Panel.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.sContainer.Panel1.ResumeLayout(false);
            this.sContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).EndInit();
            this.sContainer.ResumeLayout(false);
            this.BackPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Status_;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel BorderPanel;
        private System.Windows.Forms.Panel GC_Panel;
        private System.Windows.Forms.Panel MCS_Panel;
        private System.Windows.Forms.Panel IC_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomButton tab_GC;
        private CustomButton tab_MCS;
        private CustomButton tab_IC;
        private CustomButton tab_BSC;
        private System.Windows.Forms.Panel DrawPanelBox;
        private System.Windows.Forms.Panel SSH_Panel;
        private CustomButton tab_SSH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.SplitContainer sContainer;
        private System.Windows.Forms.Panel BSC_Panel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label BStationLable;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.NumericUpDown Rmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.NumericUpDown Rmax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.NumericUpDown Amin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.NumericUpDown Amax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.NumericUpDown Tmin;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.NumericUpDown Tmax;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.NumericUpDown Emin;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.NumericUpDown Emax;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Button Input_ResetBtn;
        private System.Windows.Forms.Button Input_SaveBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label BtnAB2;
        private System.Windows.Forms.Label BtnAB1;
        private System.Windows.Forms.Label BtnBack;
        private System.Windows.Forms.Label BtnStart;
        private System.Windows.Forms.Label BtnLB;
        private System.Windows.Forms.Label BtnRB;
        private System.Windows.Forms.Label BtnA;
        private System.Windows.Forms.Label BtnB;
        private System.Windows.Forms.Label BtnY;
        private System.Windows.Forms.Label BtnX;
        private System.Windows.Forms.Label YRotation;
        private System.Windows.Forms.Label XRotation;
        private System.Windows.Forms.Label TAxisL;
        private System.Windows.Forms.Label YAxis;
        private System.Windows.Forms.Label XAxis;
        private System.Windows.Forms.Label TAxisR;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Timer JoystickTimer;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox RPad;
        private System.Windows.Forms.PictureBox UPad;
        private System.Windows.Forms.PictureBox LPad;
        private System.Windows.Forms.PictureBox DPad;
        private System.Windows.Forms.Label AxesTrigger;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MsgPanel;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label msgTitle;
        private System.Windows.Forms.Timer MessageBoxTimer;
        private System.Windows.Forms.Label msgString;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Button OpenPuttyBtn;
        private System.Windows.Forms.TextBox puttyLocation;
        private System.Windows.Forms.Button ReloadPuttyBtn;
        private System.Windows.Forms.TextBox vncLocation;
        private System.Windows.Forms.Button OpenVncViewerBtn;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Button generalConfigReset;
        private System.Windows.Forms.Button generalConfigSave;
        private System.Windows.Forms.TextBox gc_SP;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox gc_CP;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox gc_DIP;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox gc_IP;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Button SSH_reset;
        private System.Windows.Forms.Button SSH_Save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.NumericUpDown Aux_high;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.NumericUpDown Aux_low;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.NumericUpDown Aux_mid;
        private System.Windows.Forms.Label label39;
        private CustomButton tab_ABT;
        private System.Windows.Forms.Panel ABT_Panel;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ListBox wifiList;
        private System.Windows.Forms.RichTextBox SSHDebug;
        private System.Windows.Forms.TextBox SSHCMDLine;
        private System.Windows.Forms.ListBox CMDLists;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
    }
}
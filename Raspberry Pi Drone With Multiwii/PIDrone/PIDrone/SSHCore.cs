using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.Drawing;
using System.Threading;
namespace PIDrone
{
    class SSHCore
    { 
        String IP;
        String UserName;
        String Password;
        SshClient sshClient;
        System.Windows.Forms.RichTextBox rBox;
        String CMD;
        Thread childThread;
        MainActivity mainActivity;
        List<SSHCMDRULEBOOK> SSHCMDRULE_Style = new List<SSHCMDRULEBOOK>();
        public SSHCore(System.Windows.Forms.RichTextBox rBox,MainActivity mainActivity)
        {
            this.rBox = rBox;
            this.mainActivity = mainActivity;
            InitRule();
        }
        public void ExecuteCMD(String CMD){
            this.IP = ControlsSets.BaseControlStation_TabControls.IP_ADDRESS;
            this.UserName = "pi";
            this.Password = "raspberry";
            this.CMD = CMD;
            if (childThread == null)
            {
                Utils.RBOX_AppendText(rBox, Environment.NewLine + "+ " + CMD, Color.Gray);
                ThreadStart childRefrence = new ThreadStart(Execute);
                childThread = new Thread(childRefrence);
                childThread.Start();
            }
            else
            {
                Utils.RBOX_AppendText(rBox, Environment.NewLine + "+ " + CMD, Color.Gray);
                if (CMD.ToLower().Equals("k"))
                {
                    childThread = null;
                    Utils.RBOX_AppendText(rBox, Environment.NewLine + "[ OLD THREAD KILLED ]", Color.Red);
                }
                else if (CMD.ToLower().Equals("clear"))
                {
                    childThread = null;
                    rBox.Clear();
                }
                else
                {
                    Utils.RBOX_AppendText(rBox, Environment.NewLine + "[ OLD THREAD RUNNING ]", Color.Blue);
                }
                rBox.SelectionStart = rBox.Text.Length;
                rBox.ScrollToCaret();
            }
        }
        private void Execute()
        {
            try
            {
                sshClient = new SshClient(IP, UserName, Password);
                sshClient.Connect();
                if (sshClient.IsConnected)
                {
                    SshCommand sshCMD = sshClient.RunCommand(CMD);
                    String Result = sshCMD.Result;
                    for (int i = 0; i < SSHCMDRULE_Style.Count; i++)
                    {
                        if (CMD.ToLower().Equals(SSHCMDRULE_Style[i].CMD))
                        {
                            Result = Result.Replace(SSHCMDRULE_Style[i].Key, SSHCMDRULE_Style[i].Value);
                        }
                    }
                    Utils.RBOX_AppendText(rBox, Environment.NewLine +  Result, Color.Green);
                }
                rBox.SelectionStart = rBox.Text.Length;
                rBox.ScrollToCaret();
                sshClient.Disconnect();
                this.childThread = null;//just destroy the thread :D
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void InitRule()
        {
            SSHCMDRULE_Style.Add(new SSHCMDRULEBOOK("ls", "\n", "\t"));
        }
        private class SSHCMDRULEBOOK
        {
            public String CMD;
            public String Key;
            public String Value;
            public SSHCMDRULEBOOK(String CMD, String Key, String Value)
            {
                this.CMD = CMD;
                this.Key = Key;
                this.Value = Value;
            }
        }
    }
}

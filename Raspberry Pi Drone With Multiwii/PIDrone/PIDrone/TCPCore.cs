using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PIDrone
{
    class TCPCore
    {
        TcpClient ControlClient, StatusClient;
        public NetworkStream ControlStream {get;set;}
        public NetworkStream StatusStream {get;set;}
        String IP;
        int PORT_CONTROL, PORT_STATUS,PORT_IMAGE;
        public String ConnectionStatus;
        /// <summary>
        /// <pram>TCP CORE HANDLE ALL THE TCP TRANSACTION BETN [PC to LINUX_COMPUTER]</pram>
        /// </summary>
        /// <param name="IP">USED TO SET IP ADDRESS; Default one is 127.0.0.1</param>
        /// <param name="PORT_CONTROL">USED TO SET CONTROL PORT NUMBER ; Default one is 8000</param>
        /// <param name="PORT_STATUS">USED TO SET STATUS PORT NUMBER ; Default one is 8001</param> 
        public TCPCore(String IP, int PORT_CONTROL, int PORT_STATUS,int PORT_IMAGE)
        {
            try
            {
                this.IP = IP;
                this.PORT_CONTROL = PORT_CONTROL;
                this.PORT_STATUS = PORT_STATUS;
                this.PORT_IMAGE = PORT_IMAGE;
                ControlClient = new TcpClient(IP, PORT_CONTROL); ControlStream = ControlClient.GetStream();
                StatusClient = new TcpClient(IP, PORT_STATUS); StatusStream = StatusClient.GetStream();
                ConnectionStatus = " Connected";
            }
            catch (Exception ex)
            {
                ConnectionStatus = "Connection Fail ";// +ex.ToString();
            }
        }
        public String GetSignalStrength()
        {
            String StrengthString = "";
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return StrengthString;
        }
        public void Write(NetworkStream Stream, String Message, bool isSleep = true, int sleepTime = 10)
        {
            try
            {
                if (Stream != null)
                {
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(Message);
                    Stream.Write(data, 0, data.Length);
                    if (isSleep)
                    {
                        Thread.Sleep(sleepTime);
                    }
                }
            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine("OBJECT DIsPOSE:" + e.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public String Read(NetworkStream Stream)
        {
            String AckMessage = "";
            try
            {
                if (Stream != null)
                {
                    Byte[] data = new Byte[256];
                    String ACKResponseData = String.Empty;
                    Int32 BytesData = Stream.Read(data, 0, data.Length);
                    ACKResponseData = System.Text.Encoding.ASCII.GetString(data, 0, BytesData);
                    AckMessage = ACKResponseData;
                }
            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return AckMessage;
        }
        public void Destroy()
        {
            try { this.ControlStream.Close(); } 
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            try { this.ControlClient.Close(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            try { this.StatusStream.Close(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            try { this.StatusClient.Close(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Utility {
    public static class PingPortTest {

        /// <summary>
        /// CheckIPPort 
        /// </summary>
        /// <param name="args"></param>
        public static void CheckIPPort(string[] args)
        {

            try
            {
                if (args.Length < 1)
                {
                    Console.WriteLine("Usage : CheckPort.exe [IP] [Port]");
                    Console.WriteLine("        CheckPort.exe 192.168.0.1 80"); return;
                }
                string ip = args[0];
                int port = Convert.ToInt32(args[1]);
                if (true)
                {
                    Console.WriteLine("{0} PING OK", ip);
                    if (BeginConnection(ip, port))
                    {
                        Console.WriteLine("{0}:{1} is open.", ip, port);
                    }
                    else
                    { Console.WriteLine("{0}:{1} is closed.", ip, port); }
                }
                else
                {
                    Console.WriteLine("{0} PING NG", ip);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static bool IsUsingPort(int port  = 80)
        {
            bool isAvailable = true;
            // Evaluate current system tcp connections. This is the same information provided 
            // by the netstat command line application, just in .Net strongly-typed object
            // form.  We will look through the list, and if our port we would like to use
            // in our TcpClient is occupied, we will set isAvailable to false. 
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();
            foreach (TcpConnectionInformation tcpi in tcpConnInfoArray) { if (tcpi.LocalEndPoint.Port == port) { isAvailable = false; break; } }
            // At this point, if isAvailable is tr
            return isAvailable;
        }


        /// <summary>
        /// BeginConnection
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        private static bool BeginConnection(string ip, int port)
        {
            bool result = false; Socket socket = null; 
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, false);
                IAsyncResult ret = socket.BeginConnect(ip, port, null, null);
                result = ret.AsyncWaitHandle.WaitOne(100, true);
            }
            catch { }
            finally { if (socket != null) { socket.Close(); } }
            return result;
        }

        /// <summary>
        /// BeginConnection
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        private static bool BeginConnection(string ip)
        {
            bool result = false;
            try
            {
                Ping pp = new Ping();
                PingOptions po = new PingOptions();
                po.DontFragment = true;
                byte[] buf = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaa");
                PingReply reply = pp.Send(IPAddress.Parse(ip), 10, buf, po);
                if (reply.Status == IPStatus.Success)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                return result;
            }
            catch { throw; }
        }
    }
}

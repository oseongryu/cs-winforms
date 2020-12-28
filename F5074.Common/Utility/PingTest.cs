using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace F5074.Common.Utility {
    public static class PingTest {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipAddress"></param>
        public static void getPing(string ipAddress)
        {
            Ping pingSender = new Ping();
            //PingReply reply = pingSender.Send("192.168.0.213");
            PingReply reply = pingSender.Send(ipAddress);
            //핑이 제대로 들어가고 있을 경우 
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Address: {0}", reply.Address.ToString());
                Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
            }
            //핑이 제대로 들어가지 않고 있을 경우 
            else
            {
                Console.WriteLine(reply.Status);
            }
        }

        private static string getUserIP()
        {
            string ipAddress = string.Empty;

            System.Net.IPHostEntry SystemAC = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (var address in SystemAC.AddressList)
            {
                if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ipAddress = address.ToString();
                }
            }
            return ipAddress;
        }

        private static string getHostNm()
        {
            return System.Net.Dns.GetHostName();
        }
    }
}

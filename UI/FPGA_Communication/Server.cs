using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;


/*
 * <Summary>

 * */
namespace FPGA_Communication
{
    class ServerConnection
    {

            private static Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            const int port = 2540;
            const string host = "localhost";
      

        public static void Connect( )
        {
            try
            {
                s.Connect(host, port);
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught", e);
            }
        }

        public static void Disconnect()
        {
            try
            {
                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught", e);
            }
        }
    }
}

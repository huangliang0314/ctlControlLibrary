using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace HL.Collection.Base.SocketConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] receiveBytes=new byte[1024];
            IPHostEntry ipHostEntry = Dns.GetHostEntry("127.0.0.1");
            IPAddress ipAddress = ipHostEntry.AddressList[1];
            Socket socketSender = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            int i = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Try connectting at {0}",i++ );
                    socketSender.Connect(ipAddress, 2112);
                    Console.WriteLine("Successfully connect at {0}", i);
                    break;
                }
                catch (Exception e)
                {
                    Thread.Sleep(3);
                }
            }
            Console.WriteLine("Successfully connected to {0}",socketSender.RemoteEndPoint);
            string strSenderMessage = "笨蛋qw";
            byte[] byteSenderMessage = Encoding.UTF8.GetBytes(strSenderMessage+"[FINAL]");
            socketSender.Send(byteSenderMessage);
            int totalBytesReceived = socketSender.Receive(receiveBytes);
            Console.WriteLine("Message provided from server :{0}", Encoding.UTF8.GetString(receiveBytes,0,totalBytesReceived));
            socketSender.Shutdown(SocketShutdown.Both);
            socketSender.Close();
            Console.ReadLine();
        }
    }
}

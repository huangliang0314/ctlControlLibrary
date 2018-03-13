using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace HL.Collection.Base.SocketConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting: Create Socket Object");
            Socket socketListener = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            socketListener.Bind(new IPEndPoint(IPAddress.Any,2112));
            socketListener.Listen(0);
            while (true)
            {
                Console.WriteLine("Waiting For Connection on port: 2112: Create Socket Object");
                Socket socket = socketListener.Accept();
                string receiveValue = "";
                while (true)
                {
                    byte[] receiveBytes = new byte[1024];
                    int num = socket.Receive(receiveBytes);

                    Console.WriteLine("Receiving Begin ...");
                    receiveValue += Encoding.UTF8.GetString(receiveBytes, 0, num);
                    if (receiveValue.IndexOf("[FINAL]")>-1)
                    {
                        break;
                    }
                }
                Console.WriteLine("Received Value: {0}", receiveValue);
                string replyValue = "Message Sucessful Received";
                byte[] replyMesaage = Encoding.UTF8.GetBytes(replyValue);
                socket.Send(replyMesaage);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            socketListener.Close();
        }
    }
}

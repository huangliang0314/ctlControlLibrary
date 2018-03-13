using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Diagnostics;
using System.IO;


namespace HL.Collection.Base.Http
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindEvents();
        }

        private void BindEvents()
        {
            this.Load += Form1_Load;
            this.webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //this.richTextBox1.Text = webBrowser1.DocumentText;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept","application/json;odata=verbose");
            Task<HttpResponseMessage> response = httpClient.GetAsync("http://www.baidu.com");
            Task.Run(() =>
                {
                    while (1 == 1)
                    {
                        if (response.IsCompleted)
                        {
                            Task<string> txtBaidu = response.Result.Content.ReadAsStringAsync();
                            while (1 == 1)
                            {
                                if (response.IsCompleted)
                                {
                                    string txtBaiduText = txtBaidu.Result;
                                    break;
                                }
                            }
                            break;

                        }
                    }
                }
            );
            Task.Run(() =>
            {
                //Process myProcess = new Process();
                //myProcess.StartInfo.FileName = "iexplore.exe";
                //myProcess.StartInfo.Arguments = "http://www.baidu.com";
                ////myProcess.StartTime = DateTime.Now.AddSeconds(30);
                //myProcess.Start();
            });

               // webBrowser1.Navigate("http://www.baidu.com");

            WebClient webClient = new WebClient();
            Stream stream= webClient.OpenRead("http://www.baidu.com");
            StreamReader sr = new StreamReader(stream);
            string line;
            while((line=sr.ReadLine())!=null)
            {
                this.richTextBox1.Text += line + Environment.NewLine;
            }
            sr.Close();
            stream.Close();
            string hostName=Dns.GetHostName();
            
            IPHostEntry ipHostEntry= Dns.GetHostByName(hostName);
            IPHostEntry ipHostEntry2= Dns.GetHostEntry(hostName);
            IPAddress localAddre=ipHostEntry.AddressList[0];
            string loopback = IPAddress.Loopback.ToString();
            IPHostEntry asd = Dns.Resolve("www.baidu.com");
            //IPAddress ipAddress = IPAddress.
            GetLocalIP();
#if TRACE
Trace.WriteLine("111");
            Debug.WriteLine("1222");
#endif

        }

        public static string GetLocalIP()
        {
            try
            {
                System.Net.Sockets.TcpClient c = new System.Net.Sockets.TcpClient();
                c.Connect("www.baidu.com", 80);
                string ip = ((System.Net.IPEndPoint)c.Client.LocalEndPoint).Address.ToString();
                c.Close();
                return ip;
            }
            catch (Exception)
            {
                return null;
            }
        } 

        //async Task<HttpResponseMessage> Getdata(HttpClient httpClient)
        //{
           
        //    HttpResponseMessage  response =await 
                      
        //    return response;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XmlSerializer xs=new XmlSerializer(typeof (Person));
            Person pr=new Person();
            pr.Age = 12;
            pr.Height=173.21;
            pr.Name="h";
            pr.Sex=Sex.Man;

            TextWriter tw = new StreamWriter("sds.xml");
            xs.Serialize(tw, pr);
            tw.Close();
            webBrowser1.Navigate(AppDomain.CurrentDomain.BaseDirectory + "sds.xml");

        }
    }
}

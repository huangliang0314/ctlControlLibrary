using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace HL.Collection.Base.Localization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JapaneseCalendar jc = new JapaneseCalendar();
            //Thread.CurrentThread.CurrentCulture=;
            CultureInfo ci1 = Thread.CurrentThread.CurrentUICulture;
            int i = 1;
           string strI= i.ToString("C",new CultureInfo("de-DE"));

        }
    }
}

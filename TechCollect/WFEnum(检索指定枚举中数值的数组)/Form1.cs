using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEnum_检索指定枚举中数值的数组_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FoodCategory foodCat = FoodCategory.bird;
            Array array1= Enum.GetValues(foodCat.GetType());
            Action<int> action1=new Action<int>(cal);
            Array.ForEach<int>((int[])array1, r=> {this.richTextBox1.Text += "\r\n  " + r;});
            //IEnumerable s = string.Empty as IEnumerable;
            //foreach(var s1 in s)
            //{
            //    this.richTextBox1.Text += "\r\n  " + s1;
            //}
        }

        private void cal(int obj)
        {
            this.richTextBox1.Text += "\r\n  " + obj;
        }

      
    }

      internal enum FoodCategory
      { 
            fruit= 1,
            meat=3,
            vegetable=4,
            bird=6,
            water=7,
            liquid=9
      }
}

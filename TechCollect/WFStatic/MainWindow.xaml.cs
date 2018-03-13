using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WFStatic
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.txtBox.Text +="\r\n"+ Person.mPrpStatic;
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            Person person1 = new Person();
            this.txtBox.Text += "\r\n" + Person.mPrpStatic;
            Person.mPrpStatic = "初始值2";
            this.txtBox.Text += "\r\n" + Person.mPrpStatic;
        }

       
    }

    public class Person
    {
        public static string mPrpStatic = "初始值1";

    }
}

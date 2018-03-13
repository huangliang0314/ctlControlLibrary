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
using System.Diagnostics;
using System.Threading;

namespace HL.Collection.Base.wpfParallel
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.btnClick.Click += btnClick_Click;
        }

        void btnClick_Click(object sender, RoutedEventArgs e)
        {
           /// txtConsole.Document.ClearValue(DependencyProperty.Register("",));
            List<int> lIntList = new List<int>(100000000);
            Stopwatch mObjWatch = new Stopwatch();
            int j = 0;
            mObjWatch.Start();
            for (int n = 0; n < 100000000; n++)
            {
                lIntList.Add(n);
            }
            mObjWatch.Stop();
            txtConsole.AppendText("For函数集合初始化耗时：" + mObjWatch.ElapsedMilliseconds + Environment.NewLine);


            mObjWatch.Reset();
            mObjWatch.Start();
            lIntList.ForEach(i => { int m = i; });
            mObjWatch.Stop();
            txtConsole.AppendText("集合的Foreach函数遍历耗时：" + mObjWatch.ElapsedMilliseconds+Environment.NewLine);
            mObjWatch.Reset();
            mObjWatch.Start();
            foreach(int i  in lIntList)
            {
                var m = i;
            }
            mObjWatch.Stop();
            txtConsole.AppendText("Foreach函数遍历耗时：" + mObjWatch.ElapsedMilliseconds + Environment.NewLine);
            mObjWatch.Reset();
            mObjWatch.Start();
            for (int i = 0; i < 100000000; i++)
            {
                var m = lIntList[i];
            }
            mObjWatch.Stop();
            txtConsole.AppendText("For函数遍历耗时：" + mObjWatch.ElapsedMilliseconds + Environment.NewLine);
            mObjWatch.Reset();
            mObjWatch.Start();
            Parallel.For(0, 10, i => {
                int m = lIntList[i];
                txtConsole.AppendText("值："+i+" 线程："+Task.CurrentId+" 线程： "+Thread.CurrentThread.ManagedThreadId);
            });
            mObjWatch.Stop();
            txtConsole.AppendText("并行类parralel的For函数耗时：" + mObjWatch.ElapsedMilliseconds + Environment.NewLine);
            mObjWatch.Reset();
            mObjWatch.Start();
            Parallel.ForEach(lIntList, new ParallelOptions(), i => { int m = lIntList[i]; });
            mObjWatch.Stop();
            txtConsole.AppendText("并行类parralel的For函数耗时：" + mObjWatch.ElapsedMilliseconds + Environment.NewLine);
            Parallel.Invoke();
        }

        private void txtConsole_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

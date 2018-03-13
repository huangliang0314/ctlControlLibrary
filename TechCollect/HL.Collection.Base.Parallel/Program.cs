using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace HL.Collection.Base.Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lIntList = new List<int>(10000000);
            Stopwatch mObjWatch = new Stopwatch();
            int j = 0;
            mObjWatch.Start();
            lIntList.ForEach(i=>i=j++);
            mObjWatch.Stop();
            Console.WriteLine("集合的Foreach函数耗时：" + mObjWatch.ElapsedMilliseconds);
            mObjWatch.Reset();
            mObjWatch.Start();
            foreach(int i  in lIntList)
            {
                var m = i;
            }
            mObjWatch.Stop();
            Console.WriteLine("Foreach函数耗时：" + mObjWatch.ElapsedMilliseconds);
            mObjWatch.Reset();
            mObjWatch.Start();
           
            mObjWatch.Stop();
            Console.WriteLine("并行类parralel的Foreach函数耗时：" + mObjWatch.ElapsedMilliseconds);
        }
    }
}

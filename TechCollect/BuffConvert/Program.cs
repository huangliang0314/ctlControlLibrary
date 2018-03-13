using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffConvert
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string a = "a";
            string A = "A";
            string b = "b";
            string B = "B";
            Byte[] aBytes = Encoding.UTF8.GetBytes("a");
            Byte[] ABytes = Encoding.UTF8.GetBytes("b");
            Byte[] bBytes = Encoding.UTF8.GetBytes("A");
            Byte[] BBytes = Encoding.UTF8.GetBytes("B");
            Byte[] aBBytes = Encoding.UTF8.GetBytes("aB");
            Byte[] aBytes1 = Encoding.UTF8.GetBytes("我");

            Byte[] ABytes1 = Encoding.UTF8.GetBytes("是");
            Byte[] bBytes1 = Encoding.UTF8.GetBytes("大");
            Byte[] BBytes1 = Encoding.UTF8.GetBytes("笨");
            Byte[] aBBytes2 = Encoding.UTF8.GetBytes("蛋");
            Byte[] aBBytes3 = Encoding.UTF8.GetBytes("我是大笨蛋");
            int l = "我".Length;
            Byte[] ABytes12 = Encoding.UTF8.GetBytes("知");
            string x = Encoding.UTF8.GetString(new byte[]{231,159,170});
        }
    }
}

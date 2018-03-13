using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HL.Collection.Base.Tuble
{
    class Program
    {
        static void Main(string[] args)
        {

            Tuple<string, List<string>> tuble= Tuple.Create<string, List<string>>("1", new List<string>() { "1","2"});
            Console.Write(tuble.Item1 + tuble.Item2[0]);
            Console.Read();
        }
    }
}

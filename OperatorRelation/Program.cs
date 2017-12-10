using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 5;
            Console.WriteLine("12>=5,{0}", a > b);
            string s1 = "bool", s2 = "boil";
            Console.WriteLine("bool==boil,{0}", s1 == s2);
            Console.WriteLine("bool==boil,{0}", s1 != s2);
            object s = 1, t = 1;
            Console.WriteLine(s == t);
            Console.WriteLine(s != t);
            Console.ReadKey();
        }
    }
}
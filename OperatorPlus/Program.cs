using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 5;
            string s1 = "Hello", s2 = "World";
            char c = 'e';
            Console.WriteLine("a+b={0}", a + b);
            Console.WriteLine("s1+s2={0}", s1 + s2);
            Console.WriteLine("a+s1={0}", a + s1);
            Console.WriteLine("b+c={0}", b + c);
            Console.WriteLine("{0}", (int)c);
            Console.WriteLine("连接"+s1);
            Console.ReadKey();
        }
    }
}
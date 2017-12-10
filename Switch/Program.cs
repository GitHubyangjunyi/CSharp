using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6, b = 12;
            string str;
            Console.WriteLine("请输入运算符号");
            str = Console.ReadLine();
            switch (str)
            {
                case "+": Console.WriteLine("a+b={0}", a + b); break;
                case "-": Console.WriteLine("a-b={0}", a - b); break;
                case "*": Console.WriteLine("a*b={0}", a * b); break;
                case "/": Console.WriteLine("a/b={0}", (double)a / b); break;
                default: Console.WriteLine("输入的运算符不正确！"); break;
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            long m;
            Console.WriteLine("请输入一个数值");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1, m = 1; i <= n; m *= i, i++)
            {
            }
            Console.WriteLine("{0}!={1}", n, m);
            Console.ReadKey();
        }
    }
}
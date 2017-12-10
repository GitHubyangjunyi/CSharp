using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n;
            long m = 1;
            Console.WriteLine("请输入一个数值");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                m *= i;
                i++;
            }
            Console.WriteLine("{0}!={1}", n, m);
            Console.ReadKey();
        }
    }
}
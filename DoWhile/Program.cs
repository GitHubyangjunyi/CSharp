using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n;
            Console.WriteLine("请输入一个数值");
            n = Convert.ToInt32(Console.ReadLine());
            long m = 1;
            do
            {
                m *= i;
                i++;
            } while (i <= n);
            Console.WriteLine("{0}!={1}", n, m);
            Console.ReadKey();
        }
    }
}
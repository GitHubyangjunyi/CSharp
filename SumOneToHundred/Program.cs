using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOneToHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;
            for (i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            sum = 0;
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine(sum);//偶数和2550
            sum = 0;
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    continue;
                sum += i;
            }
            Console.WriteLine(sum);//奇数和2550
            int n = 0, m = 0;
            for (i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    m += i;
                }
                else
                    n += i;
            }
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(26 / 3 + 34 % 5 + 3.6);
            Console.ReadKey();
        }
    }
}
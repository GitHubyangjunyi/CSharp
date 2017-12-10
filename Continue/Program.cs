using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num = 0;
            for (i = 100; i <= 200; i++)
            {
                if (i % 6 != 0)
                {
                    continue;
                }
                Console.Write(i + "\t");
                num++;
                if (num % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
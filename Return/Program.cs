using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, i;
            for (i = 1; i < 9; i++)
            {
                if (i == 5)
                {
                    a = i;
                    Console.WriteLine(a);
                    return;
                }
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
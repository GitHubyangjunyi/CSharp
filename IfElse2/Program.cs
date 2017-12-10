using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            if (x >= 1)
            {
                Console.WriteLine("B");
            }
            else if (x >= 0)
            {
                Console.WriteLine("A");
            }
            else if (x >= -1)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            if (x >= 0)
            {
                if (x < 1)
                {
                    Console.WriteLine("A");
                }
                else
                {
                    Console.WriteLine("B");
                }
            }
            else
            {
                if (x >= -1)
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine("D");
                }
            }
            Console.ReadKey();
        }
    }
}
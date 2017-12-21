using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0, b = 10.0, x, step = 0.001;
            x = a;
            while (F(x)!=0.0 && x<b)
            {
                x = x + step;
            }
            if (x < b)
            {
                Console.WriteLine("root is" + x);
            }
            else
            {
                Console.WriteLine("root not found");
            }
            Console.ReadKey();
        }
        static double F(double x)
        {
            return x * x - 2.0;
        }
    }
}
//这个版本无法得到正确结果
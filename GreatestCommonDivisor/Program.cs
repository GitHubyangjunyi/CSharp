using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor//最大公约数
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                z = x % y;
            }
            else
            {
                z = y % x;
            }
            if (z == 0)
            {
                z = x > y ? y : x;
            }
            while (z != 0)
            {
                x = y;
                y = z;
                if (x % y == 0)
                {
                    break;
                }
                z = x % y;
            }
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice      //分段函数
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Func(x);
            //if (x >= 0)
            //{
            //    if (x == 0)
            //    {
            //        y = 0;
            //    } else
            //        y = x + 3;
            //} else
            //{
            //    y = x*x - 1;
            //}
            /*public static*/
            int Func(int z)
            {
                int temp;
                if (x >= 0)
                {
                    if (x == 0)
                    {
                        temp = 0;
                    }
                    else
                        temp = x + 3;
                }
                else
                {
                    temp = x * x - 1;
                }
                return temp;
            }
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
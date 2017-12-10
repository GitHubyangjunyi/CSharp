using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int num = 0;
            for (i = 1; i <= 100; i++)
            {
                k = (int)Math.Sqrt((double)i);
                for (j = 2; j <= k; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (j >= k + 1)
                {
                    num++;
                    Console.Write(i + "\t");
                    if (num % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("\n才1至100之间共有{0}个素数\n", num);
            Console.ReadKey();
        }
    }
}
//外层循环变量i控制在1至100以内循环用i去除2至i的平方根（即k）之间的数如果不能整除这个数就是素数
//如果能够整除说明这不是素数使用break语句结束对这个数字的判断变量num用来统计素数的个数每行输出5个素数

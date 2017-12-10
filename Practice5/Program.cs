using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= (n - 1) / 2; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j == ((n + 1) / 2))
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write("x");
                }
                Console.WriteLine();
            }
            //int[][] jArr = new int[3][];
            //jArr[0] = new int[5];
            //jArr[1] = new int[4];
            //jArr[2] = new int[2];
            int[][] jArr = new int[n][];
            //for (i = 0; i < n; i++)
            //{
            //    for (j = 0; j < jArr.GetLength(i)-1; j++)
            //    {
            //        if (i == (n - 1) / 2)
            //            jArr[i][j] = 1;
            //    }
            //}
            //for (int i = 0; i < jArr.Length; i++)       //二维交错数组中，各个数组元素的长度是不同的
            //{
            //    for (int j = 0; j < jArr[i].Length; j++)//通过i的变化取得各个数组元素的长度
            //    {
            //        Console.Write(jArr[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            for (int a = 0; a < n; a++)
            {
                foreach (int b in jArr[1])
                {
                    Console.Write(b + "\t");
                }
            }
            Console.ReadKey();
        }
    }
}
//输出下面的图形,用户可以控制输出几行
//                                *
//                               ***
//                              *****
//                             *******
//                            *********
//                             *******
//                              *****
//                               ***
//                                *
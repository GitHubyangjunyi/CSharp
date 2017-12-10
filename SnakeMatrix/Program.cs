using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("请输入要输出的蛇形矩阵的行数\nn:");
            n = Convert.ToInt32(Console.ReadLine());
            int[][] ss = new int[n][];
            //设置n行交错数组
            for (int i = 0, j = n; i < n; i++)
            {
                ss[i] = new int[j];
                j--;
            }
            //初始化第一列
            for (int i = 1; i <= n; i++)
            {
                ss[i - 1][0] = ((i - 1) * i) / 2 + 1;
            }
            //依次初始化其余列
            for (int i = 1; i <= n - 1; i++)//要加上等于号不然最后一列的单一元素不会被初始化
            {
                for (int j = 0; j < n - i; j++)
                {
                    ss[j][i] = ss[j + 1][i - 1] + 1;
                }
            }
            //依次初始化其余列的错误方法,方法没错,原来是初始化设置不合理
            //for (int i = 1; i < n - 1; i++)
            //{
            //    for (int j=0; j < n - i; j++)
            //    {
            //        ss[j][i] = ss[j + 1][i-1] + 1;
            //    }
            //}
            //得到的输出
            //            5
            //1       2       4       7       0没加等于号最后一列未初始化
            //1       3       6       10
            //2       5       9
            //4       8
            //7                      该方法错误
            //输出交错数组
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < ss[i].Length; j++)
                {
                    Console.Write(ss[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
//蛇形矩阵是由1开始的自然数依次排列成的一个矩阵上三角形
//输出N行的蛇型矩阵
//1 3 6 10
//2 5 9
//4 8
//7
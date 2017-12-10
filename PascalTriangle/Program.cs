using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("请指定杨辉三角的长度");
            t = int.Parse(Console.ReadLine());
            int[][] arr = new int[t][];//声明初始化二维交错数组
            for (int i = 0; i < arr.Length; i++)//初始化数组arr中的数组元素
            {
                arr[i] = new int[i + 1]; //第一个数组元素有一个元素，第二行有两个，以此类推
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i][0] = 1;          //第一列元素均为1
                arr[i][i] = 1;        //对角线元素均为1
                for (int j = 1; j < arr[i].Length - 1; j++)
                {
                    arr[i][j] = arr[i - 1][j] + arr[i - 1][j - 1];//其余元素的值均为上一行同列元素与前一列元素的和
                }           //上一行同列元素//上一行前一列元素
            }
            Console.WriteLine("输出杨辉三角形");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8, }, { 9, 10, 11, 12 } };//new int [3,4]*可以省略
            int sum = 0;
            int x = arr.GetLength(1);//指定维度中的元素总数等于4
            int y = arr.Length;     //元素总数等于12
            int z = arr.Rank;      //数组的维度等于2
            int a = arr.GetLength(0);//等于3
            int b = arr.GetLength(1);//等于4
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < arr.GetLength(0); i++)//第一维有三个
            {
                int groupsum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)//第二维有四个
                {
                    groupsum += arr[i, j];
                }
                Console.WriteLine("第{0}个小组的销售总额为{1}万元", i + 1, groupsum);
            }
            Console.ReadKey();
            Console.WriteLine("调试");
            Console.ReadKey();
        }
    }
}
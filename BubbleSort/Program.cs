using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int t = 0;
            Console.WriteLine("请输入任意10个数字");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("第{0}个数：", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("输入的10个数字是：");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        t = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("排序后的数字是：");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadKey();
        }
    }
}
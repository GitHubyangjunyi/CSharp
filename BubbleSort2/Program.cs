using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int t = 0;
            Console.WriteLine("请输入任意3个数字");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("第{0}个数：", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("输入的3个数字是：");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < 3 - 1; i++)//不-1也可以但是当i=2时下面不会执行
            {
                for (int j = 0; j </*不能放等于,这样下面的arr[j+i]当i=0时下表就会超出范围*/3 - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
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
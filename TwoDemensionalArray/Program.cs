using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDemensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            Console.WriteLine("输入数组元素的值");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("请输入第{0}行元素值", i + 1);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("将二维数组元素的值以矩阵的形式输出");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("使用foreach语句将二维数组元素的值输出");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadKey();
        }
    }
}
//在C中不允许对二维和二维以上的多维数组的部分元素初始化
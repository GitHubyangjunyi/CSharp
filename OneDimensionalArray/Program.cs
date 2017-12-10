using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];//声明并初始化数组arr1
            arr1[0] = 1;
            arr1[2] = 3;
            arr1[4] = 5;
            //输出数组元素
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0}\t", arr1[i]);
            }
            Console.ReadKey();
        }
    }
}
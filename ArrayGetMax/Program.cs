using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 6, 3, 9, 8 };
            int max = GetMax(arr);
            //int max2 = GetMax(1,6,55);
            Console.WriteLine("max=" + max);
            //Console.WriteLine("max2=" + max2);
            Console.ReadKey();
        }
        public static int GetMax(/*params这个关键字注释掉会导致max2这一行报错,该关键字可以传入任意个参数*/ int[] arr)
        {
            int max = arr[0];
            for (int x = 1; x < arr.Length; x++)
            {
                if (arr[x] > max)
                    max = arr[x];
            }
            return max;
        }
    }
}
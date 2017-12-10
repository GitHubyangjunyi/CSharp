using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = GetSum(4);
            Console.WriteLine("sum=" + sum);
            int n = 99;
            int sum2;
            sum2 = Func(n);
            Console.WriteLine(sum2);
            Console.ReadKey();
        }
        //下面的方法使用递归实现求1到n的和
        public static int GetSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int temp = GetSum(n - 1);
            return temp + n;
        }
        public static int Func(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int temp = Func(n - 2);
            return temp + n;
        }
    }
}
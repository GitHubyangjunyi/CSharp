using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(3, 5);                   //调用两数相加的方法
            int product = Multiply(3, 5);//调用两数相乘的方法
            Console.WriteLine("num1*num2=" + product);
            Console.ReadKey();
        }
        //定义两数相加的方法
        public static int Multiply(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }
        //定义两数相乘的方法
        public static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("num1*num2=" + sum);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 5;
            Console.WriteLine("n1={0},n2={1}", n1, n2);
            TestFunc(ref n1, ref n2);//传递的是引用,实际上传递的是变量的地址即它和对应函数成员中的变量指向同一个存储位置
            Console.WriteLine("n1={0},n2={1}", n1, n2);
            Console.ReadKey();
        }
        public static void TestFunc(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
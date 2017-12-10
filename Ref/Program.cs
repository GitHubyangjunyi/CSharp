using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref                 //ref参数必须在方法调用前赋值
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 5;
            Console.WriteLine("n1={0},n2={1}", n1, n2);
            TestFunc(n1, n2);//方法被调用时,编译器会为每一个值类型的形参分配一个内存空间,然后复制一份实参的值到形参的内存空间
                             //方法内对数据的修改不会影响方法外的数据
            Console.WriteLine("n1={0},n2={1}", n1, n2);
            TestFunc(ref n1, ref n2);//传递的是引用,实际上传递的是变量的地址,,即它和对应函数成员中的变量指向同一个存储位置
            Console.WriteLine("n1={0},n2={1}", n1, n2);
            Console.ReadKey();
        }
        public static void TestFunc(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        public static void TestFunc(int num1, int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
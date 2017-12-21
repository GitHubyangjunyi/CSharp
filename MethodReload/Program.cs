using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReload
{
    class Program
    {
        static void Main(string[] args)
        {
            //求和方法的调用
            int sum1 = Add01(1, 2);
            int sum2 = Add02(1, 2, 3);
            double sum3 = Add03(1.2, 2.3);
            Console.WriteLine("sum1=" + sum1);
            Console.WriteLine("sum2=" + sum2);
            Console.WriteLine("sum3=" + sum3);
            //=================================================================================================================//
            Console.WriteLine();
            int sum4 = Add(3, 4);
            int sum5 = Add(5, 6, 7);
            double sum6 = Add(3.4, 4.5);
            double sum7 = Add();
            Console.WriteLine("sum4=" + sum4);
            Console.WriteLine("sum5=" + sum5);
            Console.WriteLine("sum6=" + sum6);
            Console.WriteLine("sum7="+sum7);
            //=================================================================================================================//
            Console.WriteLine();
            Console.WriteLine(Judge(1,2.00000000000000000));//编译器会首先查找精确匹配,如果找不到精确匹配,就会执行扩大基本类型转换
            Console.WriteLine(Judge(1, 2));//通过扩大基本类型转换来匹配任何一个方法,对调用进行类型转换,可以使用断点来验证执行的时哪一个函数
            Console.ReadKey();
        }
        //下面的方法实现两数相加
        public static int Add01(int x, int y)
        {
            return x + y;
        }
        //下面的方法实现三个数相加
        public static int Add02(int x, int y, int z)
        {
            return x + y + z;
        }
        //下面的方法实现两个小数相加
        public static double Add03(double x, double y)
        {
            return x + y;
        }
        //================================================定义可重载函数=============================================================//
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Add(double x=100.99, double y=100.99)
        {
            return x + y;
        }
        public static bool Judge(float x,float y)
        {
            return x < y;
        }
        public static bool Judge(double x, double y)
        {
            return x < y;
        }
    }
}
//通过在一个类中定义多个名称相同,参数个数或者参数顺序,记住参数顺序也可以不同然后进行方法重载
//方法的重载不能通过函数的返回值来区别,也不能通过类型相同而只是变量名不同的参数来区别
//如果一个方法包含必填参数可选参数和params参数则必填参数必须在可选参数之前声明而params参数必须在可选参数之后声明
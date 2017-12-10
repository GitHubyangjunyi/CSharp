using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
            long l = i;//int类型隐式转换成long类型
            Console.WriteLine("i={0},l={1}", i, l);
            int num = 4;
            short b = (short)num;//强制类型转换才不会编译错误
            Console.WriteLine(b);
            //一个int型（四个字节）的值赋给short类型（两个字节）变量b时int类型的取值范围大于short的取值范围，会导致数值溢出
            //隐式转换也叫自动类型转换条件一：彼此兼容条件二目标类型的取值范围大于源类型的取值范围
            //如条件不成立必须进行强制类型转换
            //目标类型 变量 =（目标类型）值
            Console.WriteLine("x={0:F2}", 123456789);//输出浮点数,小数点占用两位
            Console.WriteLine("x={0:F4}", 123456789);//输出浮点数,小数点占用四位
            Console.ReadKey();
        }
    }
}
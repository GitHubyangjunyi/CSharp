using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorReload2
{
    class Program
    {
        int real;
        int img;
        public Program(int a, int b)
        {
            real = a;
            img = b;
        }
        public void Display()
        {
            Console.WriteLine(" Complex.real={0},Complex.img={1}", real, img);
        }
        public static Program operator +(Program p1, Program p2)
        {
            Program p = new Program(0, 0);
            p.real = p1.real + p2.real;
            p.img = p1.img + p2.img;
            return p;
        }
        public static Program operator -(Program p1, Program p2)
        {
            Program p = new Program(0, 0);
            p.real = p1.real - p2.real;
            p.img = p1.img - p2.img;
            return p;
        }
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            a = a + b;
            Console.WriteLine(a);
            Program p1 = new Program(1, 2);
            Program p2 = new Program(3, 4);
            Program p;
            p = p1 + p2;
            p.Display();
            p1 = p1 - p2;
            p1.Display();
            Console.ReadKey();
        }
    }
}
//运算符重载是指允许用户对已有运算符进行重新定义,使用operator关键字按照自己的定义要求进行运算
//运算符重载格式如下:
//public static 返回值类型 operator 运算符(参数列表)
//在运算符重载时,参数只能时值参数
//C#支持运算符重载,.NET不支持
//不能改变运算符的优先级,结合性和操作数的数量
//不能创建新的运算符
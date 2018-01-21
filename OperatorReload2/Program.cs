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
            Console.WriteLine("Complex.real={0},Complex.img={1}", real, img);
        }
        public static Program operator +(Program p1, Program p2)
        {
            Program p = new Program(0, 0)
            {
                real = p1.real + p2.real,
                img = p1.img + p2.img
            };
            return p;
        }
        public static Program operator -(Program p1, Program p2)
        {
            Program p = new Program(0, 0)
            {
                real = p1.real - p2.real,
                img = p1.img - p2.img
            };
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
//重要的事情说三遍
//重载运算符是具有特殊名称的函数,是通过关键字operator后跟运算符的符号来定义的,与其他函数一样,重载运算符有返回类型和参数列表
//重载运算符是具有特殊名称的函数,是通过关键字operator后跟运算符的符号来定义的,与其他函数一样,重载运算符有返回类型和参数列表
//重载运算符是具有特殊名称的函数,是通过关键字operator后跟运算符的符号来定义的,与其他函数一样,重载运算符有返回类型和参数列表
//运算符重载格式如下:
//public static 返回值类型 operator 运算符(参数列表)
//在运算符重载时,参数只能时值参数
//C#支持运算符重载,.NET不支持
//不能改变运算符的优先级,结合性和操作数的数量
//不能创建新的运算符
//1. 运算符重载概述
//运算符重载是指同名运算符可用于运算不同类型的数据,C#允许重载运算符,以供自己的类使用,其目的是让使用类对象像使用基本数据类型一样自然、合理
//例如，设计一个名称为MyAdd的类,其中对“+”运算符进行了重载,这样对于该类的两个对象a和b,就可以进行a+b的运算
//若要重载某个运算符,需要编写一个函数,其基本语法格式如下：
//public static 返回类型 operator 运算符(参数列表)
//{    }
//2.一元运算符重载
//一元运算符重载时需注意以下几点:
//一元运算符+、-、!、~必须使用类型T的单个参数,可以返回任何类型
//一元运算符++、--必须使用类型T的单个参数,并且要返回类型T
//一元运算符true、false必须使用类型T的单个参数,并且要返回类型bool
//class MyOp
//{
//    private int n;
//    public MyOp(int n1) { n = n1; }
//    public static MyOp operator ++(MyOp obj)//重载运算符++
//    { return new MyOp(obj.n + 1); }
//    public void dispdata()
//    { Console.WriteLine("n={0}", n); }
//}
//执行以下语句:
//MyOp a = new MyOp(2);
//a++;
//a.dispdata();	//n=3
//3.二元运算符重载
//一个二元运算符必须有两个参数，而且其中至少一个必须是声明运算符的类或结构的类型,二元运算符可以返回任何类型
//二元运算符的签名由运算符符号和两个形式参数组成
//class MyOp1
//{
//    private int n;
//    public MyOp1() { }
//    public MyOp1(int n1) { n = n1; }
//    public static MyOp1 operator +(MyOp1 obj1, MyOp1 obj2)   //重载+
//    { return new MyOp1(obj1.n + obj2.n); }
//    public void dispdata()
//    { Console.WriteLine("n={0}", n); }
//}
//执行以下语句:
//MyOp1 a = new MyOp1(2), b = new MyOp1(3), c;
//c=a+b;
//c.dispdata();//n=5
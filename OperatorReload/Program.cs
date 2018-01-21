using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorReload//重点是要把主类当成对象来处理
{
    class Program
    {
        int x, y;
        public Program()
        {
            
        }
        public Program(int a, int b)
        {
            x = a;
            y = b;
        }
        public static Program operator ++(Program p)
        {
            p.x++;
            p.y++;
            return p;
        }
        public static Program operator --(Program p)
        {
            p.x--;
            p.y--;
            return p;
        }
        public void Display()
        {
            Console.WriteLine("Point.x={0},Point.y={1}", x, y);
        }
        public static Program operator +(Program p1, Program p2)
        {
            Program p = new Program(0, 0)
            {
                x = p1.x + p2.x,
                y = p1.y + p2.y
            };
            return p;
        }
        public static Program operator -(Program p1, Program p2)
        {
            Program p = new Program(0,0);
            p.x = p1.x - p2.x;
            p.y= p1.y - p2.y;
            return p;
        }
        static void Main(string[] args)
        {
            Program a = new Program(10, 20);
            Program b = new Program(30, 40);
            b = a + b;
            a++; b++;
            a--; b--;
            a.Display();
            b.Display();
            b = a - b;
            b.Display();
            Console.WriteLine(a);
            Console.WriteLine(a.x);
            Console.ReadKey();
        }
    }
}
//运算符重载是指允许用户对已有运算符进行重新定义,使用operator关键字按照自己的定义要求进行运算
//运算符重载格式如下:
//public static 返回值类型 operator 运算符(参数列表)
//在运算符重载时,参数只能是值参数
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
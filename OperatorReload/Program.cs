using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorReload
{
    class Program
    {
        int x, y;
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
            Program p = new Program(0, 0);
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;
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
            Console.WriteLine(a);
            Console.WriteLine(a.x);
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
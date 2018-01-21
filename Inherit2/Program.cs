using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit2
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C(1, 2, 3);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
    class A
    {
        private int x;  //私有字段
        public void Funa()//公有方法
        {
            Console.WriteLine("A类的Funa()方法被执行!");
        }
        public A(int x1)//构造函数
        {
            x = x1;
            Console.WriteLine("调用A的重载构造函数");
        }
        ~A()//析构函数
        {
            Console.WriteLine("调用A的析构函数:x={0}", x);
        }

    }
    class B : A
    {
        private int y;//私有字段
        public void Funb()//公有方法
        {
            Console.WriteLine("B类的Funb()方法被执行!");
        }
        public B(int x1, int y1) : base(x1)//构造函数
        {
            y = y1;
            Console.WriteLine("调用B的重载构造函数");
        }
        ~B()//析构函数
        {
            Console.WriteLine("调用B的析构函数:y={0}", y);
        }
    }
    class C : B//从B派生出C
    {
        private int z;
        public C(int x1, int y1, int z1) : base(x1, y1)//构造函数
        {
            z = z1;
            Console.WriteLine("调用C的重载构造函数");
        }
        ~C()//析构函数
        {
            Console.WriteLine("调用C的析构函数:z={0}", z);
        }
    }
}
//派生类将获取基类的所有非私有数据和行为
//调用基类的带参数构造函数的方法是将派生类的带参数构造函数作如下设计：
//public 派生类名(参数列表1) : base(参数列表2)
//{
//    //派生类带参数构造函数的代码
//}
//子类中使用base关键字访问的基类成员
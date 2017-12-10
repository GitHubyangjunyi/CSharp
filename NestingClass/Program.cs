using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Outer outer = new Outer();
            outer.OuterMethod();
            Console.ReadKey();
        }
    }
    class Outer
    {
        class Nesting//声明嵌套类
        {
            public int num = 10;
        }
        public void OuterMethod()
        {
            Nesting nesting = new Nesting();//在外部类的方法中创建嵌套类的对象
            Console.WriteLine("调用嵌套类的字段num=" + nesting.num);//调用嵌套类的字段
        }
    }
}
//首先定义一个外部类Outer,在Outer内部定义一个嵌套类Nesting,接着又为嵌套类添加一个名为num的字段
//然后在外部类Outer的OuterMethod方法中创建内部类的对象nesting
//最后通过nesting.num的方式获得嵌套类字段num的值
//需要注意的是,外部类和嵌套类的非静态成员可以重名,在对非静态成员进行访问时,需要先创建它所在类的对象
//在嵌套类中不能声明静态成员,但嵌套类可以直接引用外部类的静态成员
//想要在作用域外引用嵌套类,需要使用类似Outer.Nesting的完整限定名方式
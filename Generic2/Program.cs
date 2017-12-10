using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geometric<Square> sq = new Geometric<Square>();//实例化T类型为一个Square对象
            //sq.MyClass = new Square(20);
            Geometric<Square> sq = new Geometric<Square>
            {
                MyClass = new Square(20)//系统自动简化的写法
            };//实例化T类型为一个Square对象
            sq.Print();
            Geometric<Rectangle> rect = new Geometric<Rectangle>
            {
                MyClass = new Rectangle(20, 10)
            };////实例化T类型为一个Rectangle对象
            rect.Print();
            Geometric<Circle> cl = new Geometric<Circle>
            {
                MyClass = new Circle(15)
            };//实例化T类型为一个Circle对象
            cl.Print();
            Console.ReadKey();
        }
    }
    public class Geometric<T>//T为参数类型,用来接收不同的参数类型
    {
        T m_Myclass;
        public T MyClass
        {
            get { return m_Myclass; }
            set { m_Myclass = value; }
        }
        public void Print()
        {
            string words = MyClass.ToString();
            Console.WriteLine(words);
        }
    }
    public class Square
    {
        public double area;
        public double circumference;
        public Square(double l)
        {
            area = l * l;
            circumference = 4 * l;
        }
        public override string ToString()
        {
            string words = "正方形的面积是:" + area + ",周长是:" + circumference;
            return words;
        }
    }
    public class Rectangle
    {
        public double area;
        public double circumference;
        public Rectangle(double l, double w)
        {
            area = l * w;
            circumference = 2 * (1 + w);
        }
        public override string ToString()
        {
            string words = "长方形的面积是:" + area + ",周长是:" + circumference;
            return words;
        }
    }
    public class Circle
    {
        public double area;
        public double circumference;
        public Circle(double r)
        {
            area = Math.PI * r * r;
            circumference = 2 * Math.PI * r;
        }
        public override string ToString()
        {
            string words = "圆的面积是:" + area + ",周长是:" + circumference;
            return words;
        }
    }
}
//泛型是C#2.0和公共语言运行库中新增的一个功能,它将类型参数的概念引入到.NET Framework中
//当遇到两个模块的功能非常相似时,一个处理数值数据,一个处理字符串数据,或者其他自定义的数据类型时
//必须写多个分别处理多种数据.采用泛型,可以在方法中传入通用的数据类型,就可以将代码合并在一个方法中
//泛型类和泛型方法具有可重用型,类型安全和效率高的优点
//(1)定义泛型类
//[访问修饰符] class 类名<T>
//  {
//     类的成员
//  }
//(2)定义泛型方法
//[访问修饰符] 返回类型 方法名<T>(参数列表)
//  {
//     方法体
//  }
//其中参数T用来定义泛型类和泛型方法的占位符,并不是一种数据类型,仅代表可能的数据类型,只有在实例化时才指定数据类型
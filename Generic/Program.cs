using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Exp.Show(22);
            Console.WriteLine("=============");
            Exp.Show(2312313112);
            Console.WriteLine("=============");
            Exp.ShowObject(34223423.2423423);
            Console.WriteLine("=============");
            Exp.ShowGeneric<int>(1);
            Console.WriteLine("=============");
            Exp.ShowGeneric<double>(1.1);
            Console.WriteLine("=============");
            Console.WriteLine("=============");
            Chinese chinese = new Chinese()
            {
                Id = 123,
                Name = "张三",
                Age = 25,
                ZhongGuo = "中国"
            };
            Exp.ShowGeneric<People>(chinese);
            Exp.SayHi<People>(chinese);

            Cat cat = new Cat();
            Exp.SayHi<Cat>(cat);//cat不继承自People类不能使用

            Console.ReadKey();
        }
    }

    public class Exp//关于之前的方法重载
    {
        public static void Show(int i)
        {
            Console.WriteLine("{0}类型为{1}", i, i.GetType());
        }

        public static void Show(long i)
        {
            Console.WriteLine("{0}类型为{1}", i, i.GetType());
        }

        public static void ShowObject(object i)//所有类的基类object类
        {
            Console.WriteLine("{0}类型是{1}", i, i.GetType());
        }

        public static void ShowGeneric<T>(T x)//使用泛型替代函数重载,占位符T指定参数
        {
            Console.WriteLine("{0}类型是{1}", x, x.GetType());
        }

        public static void SayHi<T>(T x) where T : People//泛型约束,这样就可以使用泛型约束的类型的方法或属性
        {
            Console.WriteLine("{0},{1},{2}", x.Id, x.Name, x.Age);
            x.Say();
        }

        public static void SayHi(object x)//无泛型约束,只能使用object提供的默认方法
        {
            Console.WriteLine(x.GetType());
        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Say()
        {
            Console.WriteLine("{0}说,Hi!", this.Name);
        }

    }

    public class Chinese : People
    {
        public string ZhongGuo { get; set; }
    }

    public class Cat : People
    {
        public override void Say()
        {
            Console.WriteLine("!!!");
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
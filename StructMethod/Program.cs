using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();//自动调用类的构造方法
            Console.WriteLine();
            Chinese ch = new Chinese();
            Console.ReadKey();
        }
    }
    public class Person    //在一个类中定义的方法如果同时满足下列条件,则是一个构造函数
    {                     //(1)方法名与类名相同,大小写一致
        public Person()  //(2)在方法前面没有返回值类型的声明,也没有void修饰符,可以有参数,也可以没有参数
        {               //(3)在方法中不能使用return语句返回一个值
            Console.WriteLine("无参的构造方法被调用了!");
                      //(4)构造函数通常是public类型的,如果声明为private型,则该类不能实例化
                     //这适用用于含有静态成员的类
                    //构造函数的作用是完成类的初始化工作,所以在构造函数中不能对类的实例进行初始化以外的事
                   //也不要尝试显式地调用构造函数,解决方法可以用this关键字,参照实例ThisMethod
        }         //可以用构造函数初始化私有成员
    }
    public class Chinese : Person//实例化对象时会先调用父类的构造函数,接着调用自己的构造函数
    {
        public Chinese()
        {
            Console.WriteLine("自身的构造方法!");
        }
    }
}
//在C#中声明类时,即使没有显式声明构造函数,编译器也会自动添加一个默认的构造函数,如果提供了带参数的构造函数,编译器将不再自动提供默认的构造函数
//除此之外,可以根据用户需要,创建自己的构造函数.实际上,任何构造函数在执行时都隐式调用了系统提供的默认构造函数base()
//实例构造函数可以被重载,但是不能被继承,因为一个类除了自己的实例构造函数外不会有其他的实例构造函数
//用static修饰符修饰的构造函数是静态构造函数,用于初始化静态变量,因为构造函数属于类不属于对象,所以静态函数只会被执行一次
//静态构造函数既没有访问修饰符也没有参数,并且在一个类中只能有一个静态构造函数,它可以和一个无参的构造函数并存
//其他C#代码从来不调用它,但在加载类时,总是由.NET运行库调用它,所以像public或private这样的访问修饰符就没有任何意义
//出于同样原因,静态构造函数不能带任何参数,一个类也只能有一个静态构造函数。很显然,静态构造函数只能访问类的静态成员
//不能访问类的实例成员尽管参数列表相同,但这并不矛盾,因为在加载类时执行静态构造函数,而在创建实例时执行实例构造函数,所以何时执行哪个构造函数不会有冲突
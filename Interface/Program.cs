using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Eat();
            dog1.Run();
            dog1.LiveOnLand();
            Console.WriteLine("////////////////////");
            IHello x = new Derived();
            x.Hello();
            Console.ReadKey();
        }
    }
    interface IAnimal
    {
        void Eat();//与抽象方法的差别,无abstract
        void Run();
    }
    interface ILandAnimal : IAnimal
    {
        void LiveOnLand();
    }
    class Dog : ILandAnimal//实现了接口就要使用public修饰
                           //子类重写父类方法时,不能使用比父类方法更为严格的访问权限,如果父类方法访问修饰符是public,子类方法就不能是private
    {
        public void Eat()
        {
            Console.WriteLine("实现Eat方法!");
        }
        public void Run()
        {
            Console.WriteLine("实现Run方法!");
        }
        public void LiveOnLand()
        {
            Console.WriteLine("实现LiveOnLand方法!");
        }
    }
    interface IHello
    {
        void Hello();
    }
    class Base : IHello
    {
        public void Hello()
        { System.Console.WriteLine("Hello in Base!"); }
    }
    class Derived : Base
    {
        public new void Hello()
        { System.Console.WriteLine("Hello in Derived!"); }
    }
}
//接口是由方法属性事件和索引器这四种成员类型任意组合构成的框架,没有描述任何对象的示例
//接口不包含常量,字段,运算符,示例构造函数,析构函数或其他类型,也不包含静态成员
//接口成员是自动公开的,不包含访问修饰符.接口中定义的方法和变量都包含一些默认的修饰符,方法默认使用public修饰
//如果一个类中的所有方法都是抽象的,可以将这个类定义成接口(Interface)
//不可以通过实例化对象的方式来调用接口中的方法,需要创建一个子类,在子类中实现接口中所有的抽象方法
//一个接口还可以去继承另一个接口,所以一个类可以实现多个接口
//[修饰符] interface 接口名称 [:基接口列表] 
//{
//	接口体成员列表
//} 
//修饰符有new和四个访问修饰符：public、protected、internal、private
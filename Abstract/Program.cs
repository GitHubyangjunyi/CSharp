using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Shout();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract void Shout();//没有方法体,也就是连大括号也没有!
    }
    abstract class Dogs : Animal
    {
        //还是没实现,定义成抽象类去继承抽象类Annimal
    }
    class Dog : Dogs
    {
        public override void Shout()
        {
            //throw new NotImplementedException();
            Console.WriteLine("重写的抽象方法被调用!");
        }
    }
}
//由于有时候定义类的方法时无法具体确定方法的实现方式,C#允许在定义方法时不写方法体
//不包含方法体的方法为抽象方法,抽象方法必须使用abstract关键字修饰,不允许使用static或者virtual关键字
//在定义抽象类时,必须把含有抽象方法的类声明为抽象类,但抽象类可以不包含抽象方法
//抽象类是不可以被实例化的,只能作为其他类的基类,因为抽象类中可能包含抽象方法,抽象方法是没有方法体的,隐式的虚方法,不可以被调用
//如果想要调用抽象类中定义的方法,需要创建一个子类,在子类中实现抽象类的抽象方法和抽象访问器
//密封类和抽象类是互斥的
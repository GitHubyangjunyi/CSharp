using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal an = new Animal();
            an.Shout();
            an.New();
            Dog dog = new Dog();
            dog.Shout();
            dog.New();
            BlackDog bd = new BlackDog();
            bd.New();
            Console.Read();
        }
    }
    class Animal
    {
        public virtual void Shout()//使用virtual关键字定义可重写的方法
        {
            Console.WriteLine("动物叫!");
        }
        public void New()
        {
            Console.WriteLine("动物的原生方法!");
        }
    }
    class Dog : Animal
    {
        public sealed override void Shout()//密封了Shout方法,下面无法重写.使用override关键字重写方法.子类方法名,参数类型和参数个数必须与父类一致
        {
            base.Shout();//调用动物的原生方法
            Console.WriteLine("狗的叫声!");
        }
        public new void New()
        {
            Console.WriteLine("用new关键字屏蔽动物的原生方法!");
        }
    }
    sealed class BlackDog : Dog
    {
        //public override void Shout()//已经被密封无法重写
        //{
        //    Console.WriteLine("黑色狗的叫声!");
        //}
        public new void New()
        {
            Console.WriteLine("用new关键字屏蔽动物和狗的原生方法!");
        }
    }
    //class WhiteDog : BlackDog//密封了BlackDog,无法继承
    //{

    //}
}
//sealed关键字修饰的类不能被继承,不能派生子类,这样的类叫做密封类
//使用override关键字重写方法.子类方法名,参数类型和参数个数必须与父类一致
//子类重写父类方法时,不能使用比父类方法更为严格的访问权限,如果父类方法访问修饰符是public,子类方法就不能是private
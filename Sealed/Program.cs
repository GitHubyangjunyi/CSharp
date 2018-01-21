using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal an = new Animal();
            an.Shout();
            Dog dog = new Dog();
            dog.Shout();
            Console.WriteLine("////////////////////////////////////////");
            A a1 = new A();
            B b1 = new B();
            C c1 = new C();
            a1.F();
            a1.G();
            b1.F();
            b1.G();
            c1.F();
            c1.G();
            a1 = c1;
            a1.G();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Shout()//使用virtual关键字定义可重写的方法
        {
            Console.WriteLine("动物叫!");
        }
    }
    class Dog : Animal
    {
        public sealed override void Shout()//密封了Shout方法,下面无法重写.使用override关键字重写方法.子类方法名,参数类型和参数个数必须与父类一致
        {
            base.Shout();
            Console.WriteLine("狗的叫声!");
        }
    }
    sealed class BlackDog : Dog
    {
        //public override void Shout()
        //{
        //    Console.WriteLine("黑色狗的叫声!");
        //}
    }
    //class WhiteDog : BlackDog//密封了BlackDog,无法继承
    //{

    //}
    class A
    {        public virtual void F()
        {
            Console.WriteLine("A.F");
        }        public virtual void G()
        {
            Console.WriteLine("A.G");
        }
    }
    class B : A
    {        sealed override public void F()
        {
            Console.WriteLine("B.F");
        }        override public void G()
        {
            Console.WriteLine("B.G");
        }
    }
    class C : B
    {        override public void G()
        {
            Console.WriteLine("C.G");
        }
    }
}
//sealed关键字修饰的类不能被继承,不能派生子类,这样的类叫做密封类
//使用override关键字重写方法.子类方法名,参数类型和参数个数必须与父类一致
//子类重写父类方法时,不能使用比父类方法更为严格的访问权限,如果父类方法访问修饰符是public,子类方法就不能是private
//密封类和抽象类是互斥的
//为了说清楚你这个问题，我得打很多字
//当你设计一个类并且在设计的时候就确定不希望将来有人（或者你自己）因为凌乱的继承关系,使这个类的最初动机变得扑朔迷离的时候,可以将这个类sealed（为什么要不希望自己继承这个类后做改动？因为你的脑袋并不是电脑,你的记性并不是那么好,最初的设计初衷,在以后系统越来越庞大的时候,你可能自己都忘了自己当初设计的这个类可能考虑到的某些很细微的因素,这个因素要求你将来不要改变这个类的成员或者任何属性）,当你有个基类A然后有个类B继承A然后类C又继承B类D又继承类C的时候你可能会发生凌乱,这个时候,有些类在设计之初你就可以将它sealed,以确保将来在某一个时刻脑袋短路的情况想把这个类继承出一个子类来改写的时候,编译器就会报错提示你,“唤起”你的记忆
//比如.net中,你可能没注意到过,struct也是sealed的,你不能继承一个struct,另外.net framework中还有一些成员都是静态类型的类,比如Pen和Brushes也是sealed的,因为画笔和画刷在设计之初都已经定义好了它都有哪些颜色,并且不希望将来改变画笔和画笔的这些属性,所以直接给它sealed掉
//另外如果你的程序中有用到反射的话，CLR对用了sealed关键字的类和属性会比普通的类有一点性能上的提升。因为反射需要找回某个类的属性，没有继承关系的类，它的“关系网”不复杂，CLR能够很轻易地定位它的“位置”
//sealed还可以用于限制类成员方法等
//比如你有一个类A包含了一个vitual虚方法FOO1，另外一个类B继承了A，并且还有另外一个类C继承了类B，在这种情况下，类C可以跳过类B而直接从类A override 方法 FOO1，而不管类B是否override了方法FOO1，这个时候很容易发生凌乱。你的设计结构很有可能拎不清了。
//什么时候用sealed关键字？事实上，所有的类在设计之初，你都可以设计为sealed，直到你将来在设计别的类的时候，确定需要从这个类有继承关系，因为任何类sealed以后，你还可以将它unsealed（直接以掉sealed关键字）
//另外，在一些类含有一些安全方面考虑的成员或者属性，不希望被别的类继承或者改变的时候，可以设计为sealed
//总而言之，言而总之，sealed关键字有一部分用途比如CLR反射时候性能方面的优化，但是最主要的目的应该是为了帮助开发人员尽量避免在设计和编程的过程人为的犯错，让你在连续加班48个小时后保持清晰的思路记得你当初设计的某个不希望被继承改动的类的目的而不犯错，要求是不是太高了！所以，微软的天才们设计了这个关键字，帮助了大家一把，让这个需要注意和提醒的事情，交给了CLR和编译器
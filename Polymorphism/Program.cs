using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal an1 = new Dog("小小");//创建Cat对象,使用Animal类型的变量an1引用
            Console.WriteLine("========================================");
            Animal an2 = new Cat();//创建Dog对象,使用Animal类型的变量an2引用
            Console.WriteLine("========================================");
            AnimalShout(an1);
            Console.WriteLine("========================================");
            AnimalShout(an2);
            Console.WriteLine("========================================");
            Cat an3 = new Cat();
            Console.WriteLine("========================================");
            an3.PrintName();
            Console.WriteLine("========================================");
            Animal fox1 = new Fox();//子类Fox指向父类
            Console.WriteLine("========================================");
            bool result = fox1 is Fox;//使用is关键字判断fox1能否转换成为Fox类型
            if (result)
            {
                Console.WriteLine("fox1能转换成为Fox类型!");
            }
            else
            {
                Console.WriteLine("fox1不能能转换成为Fox类型!");
            }
            Console.WriteLine("========================================");
            fox1.Shout();//fox1无法调用Run方法,可以调用Shout方法
            Console.WriteLine("========================================");
            Fox fox2 = fox1 as Fox;//as关键字除了判断功能外,还有直接转换的功能,这句实现可以省略下面的Fox fox2 = (Fox)fox1;语句
            //Fox fox2 = (Fox)fox1;//父类对象强制转换成为子类类型,可以调用Run方法
            fox2.Run();
            Console.WriteLine("========================================");
            Console.ReadKey();
        }
        public static void AnimalShout(Animal an)//定义一个静态方法接收一个Animal类型的参数
        {
            an.Shout();
        }
    }
    class Animal
    {
        public string name = "动物类";
        public Animal()
        {
            Console.WriteLine("默认的构造方法!");
        }
        public Animal(string name)
        {
            Console.WriteLine("Animal类有参的构造方法在创建Dog类对象后被立刻调用!");
        }
        public virtual void Shout()//使用virtual关键字定义可重写的方法
        {
            Console.WriteLine("动物叫!Animal类中的Shout方法被执行!");
        }
    }
    class Dog : Animal
    {
        public override void Shout()//使用override关键字重写方法.子类方法名,参数类型和参数个数必须与父类一致
        {
            //base.Shout();//调用父类的方法
            Console.WriteLine("狗的叫声!Dog类中的Shout方法被执行!");
        }
        public Dog(string name) : base(name)
        {
            Console.WriteLine("Dog类的有参方法被执行,名字是:" + name);
        }
    }
    class Cat : Animal
    {
        public override void Shout()//使用override关键字重写方法.子类方法名,参数类型和参数个数必须与父类一致
        {
            //base.Shout();
            Console.WriteLine("猫的叫声!Cat类中的Shout方法被执行!");
        }
        public void PrintName()
        {
            Console.WriteLine("name=" + base.name);
        }
    }
    class Fox : Animal
    {

        public void Run()
        {
            Console.WriteLine("狐狸在跑!Fox类中的Run方法被执行!");
        }
    }
}
//在设计一个方法时,通常希望该方法具有通用性.例如要实现一个动物叫的方法,可以在方法中接受动物类型的参数,从而实现多态
//同一操作作用于不同对象,产生不同结果或者说不同对象收到相同的消息产生不同的动作
//一种多态是编译时的多态性,这种多态性是通过方法和运算符重载来实现的
//另一种多态是运行时的多态性,是指系统直到运行结束才根据实际情况决定采取何种操作
//为实现多态,允许使用一个父类类型的变量来引用一个子类类型的变量,根据被引用子类对象特征的不同,得到不同的运行结果
//上面的代码使用重写实现多态
//当子类重写父类的方法后,子类对象将无法直接访问父类被重写的方法,base关键字专门用于在子类中访问父类的成员
//base关键字只能在构造函数,非静态方法,或非静态属性的访问器中使用,可以调用基类中的任何方法
//里氏转换原则:
//1子类对象可以直接赋给父类变量
//2将父类变量转换成为子类类型
//要想将父类的变量转换为子类的类型,只能在一种特殊情况下实现,即父类变量引用的是当前的子类对象,这样才可以转换回去
//但是在不知道Animal/Fox类之间是否存在继承关系时,如果将Fox类型转换为Animal类型时就可能出现未知错误,所以C#提供了is和as关键字:
//is和as关键字都可以用来判断父类对象是否指向了子类对象,as关键字除了判断功能外,还有直接转换的功能
//如果判断成功就直接进行类型转换,如果失败就返回null
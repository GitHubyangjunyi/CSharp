using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism//多态
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
            Console.WriteLine("==============里氏转换原则==============");
            Animal fox1 = new Fox();//子类Fox指向父类???
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
            Fox fox2 = fox1 as Fox;//as关键字除了判断功能外,还有直接转换的功能,这句实现可以省略下面的Fox fox2 = (Fox)fox1;
            //as关键字,如果能够转换则返回一个对应的对象,否则返回null
            //Fox fox2 = (Fox)fox1;//因为父类对象装的是子类对象,父类对象强制转换成为子类类型,可以调用Run方法
            fox2.Run();
            fox1 = fox1 as Fox;
            fox1.Shout();//还是不能调用Run方法???
            Cat fox3 = fox1 as Cat;//fox3指向null
            //fox3.Shout();//将会报错
            Console.WriteLine("========================================");
            //可以声明一个Animal类的数组,可以存所有派生类的对象
            /////////////////////下面的代码是关于多态的更多实际意义的是实现//////////////////////////////////////////
            Person[] per = new Person[5];
            Random r = new Random();
            for (int i = 0; i < per.Length; i++)
            {
                int rnum = r.Next(1,4);
                switch (rnum)
                {
                    case 1: per[i] = new Person();
                        break;
                    case 2: per[i] = new X();
                        break;
                    case 3: per[i] = new Y();
                        break;
                    case 4: per[i] = new Z();
                        break;
                }
            }
            for (int i = 0; i < per.Length; i++)
            {
                if (per[i] is Person)
                {
                    ((Person)per[i]).PersonSay();
                }
                if (per[i] is X)
                {
                    ((X)per[i]).XSay();
                }
                if (per[i] is Y)
                {
                    ((Y)per[i]).YSay();
                }
                if (per[i] is Z)
                {
                    ((Z)per[i]).ZSay();
                }
            }
            Console.ReadKey();
        }
        //在设计一个方法时,通常希望该方法具有通用性.例如要实现一个动物叫的方法,可以在方法中接受动物类型的参数,从而实现多态
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
            Console.WriteLine("动物类默认的构造方法!");
        }
        public Animal(string name)
        {
            Console.WriteLine("Animal类有参的构造方法在创建Dog类对象后被立刻调用!"+this.name);//此处的name并不是狗而是动物类
        }
        public virtual void Shout()//使用virtual关键字定义可重写的方法
        {
            Console.WriteLine("动物叫!Animal类中的Shout方法被执行!");
        }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name)//通过base显示调用父类的构造函数并传入name
        {
            Console.WriteLine("Dog类的有参方法被执行,名字是:" + name);//如果用base.name那么将会使用动物类这个字段
        }
        public override void Shout()//使用override关键字重写方法.子类方法名,参数类型和参数个数必须与父类一致
        {
            base.Shout();//调用父类的方法
            Console.WriteLine("狗的叫声!Dog类中的Shout方法被执行!");
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
            Console.WriteLine("name=" + base.name);//如果用base.name那么将会使用动物类这个字段,用this.name将会是猫的名字,此结论未测试,因为要改动代码较多
        }
    }
    class Fox : Animal
    {
        public void Run()
        {
            Console.WriteLine("狐狸在跑!Fox类中的Run方法被执行!");
        }
    }
    /////////////////////下面的代码是关于多态的更多实际意义的是实现//////////////////////////////////////////
    public class Person
    {
        public void PersonSay()
        {
            Console.WriteLine("人类的方法!");
        }
    }
    public class X:Person
    {
        public void XSay()
        {
            Console.WriteLine("X的方法!");
        }
    }
    public class Y:Person
    {
        public void YSay()
        {
            Console.WriteLine("Y的方法!");
        }
    }
    public class Z:Person
    {
        public void ZSay()
        {
            Console.WriteLine("Z的方法!");
        }
    }
}
//在设计一个方法时,通常希望该方法具有通用性.例如要实现一个动物叫的方法,可以在方法中接受动物类型的参数,从而实现多态
//同一操作作用于不同对象,产生不同结果或者说不同对象收到相同的消息产生不同的动作
//一种多态是编译时的多态性,这种多态性是通过方法重载和运算符重载来实现的
//另一种多态是运行时的多态性,是指系统直到运行结束才根据实际情况决定采取何种操作
//为实现多态,允许使用一个父类类型的变量来引用一个子类类型的变量,根据被引用子类对象特征的不同,得到不同的运行结果
//上面的代码使用重写实现多态
//当子类重写父类的方法后,子类对象将无法直接访问父类被重写的方法,base关键字专门用于在子类中访问父类的成员
//base关键字只能在构造函数,非静态方法,或非静态属性的访问器中使用,可以调用基类中的任何方法
//里氏转换原则:
//1子类对象可以直接赋给父类变量
//2将父类变量转换成为子类类型
//记住一点,子类可以调用父类的成员,父类不能调用子类的成员
//要想将父类的变量转换为子类的类型,只能在一种特殊情况下实现,即父类变量引用的是当前的子类对象,这样才可以转换回去
//但是在不知道Animal/Fox类之间是否存在继承关系时,如果将Fox类型转换为Animal类型时就可能出现未知错误,所以C#提供了is和as关键字:
//is和as关键字都可以用来判断父类对象是否指向了子类对象,as关键字除了判断功能外,还有直接转换的功能
//如果判断成功就直接进行类型转换,如果失败就返回null
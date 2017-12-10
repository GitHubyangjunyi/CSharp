using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleClass ic1 = SingleClass.SingleMethod();
            SingleClass ic2 = SingleClass.SingleMethod();
            if (ic1 == ic2)
            {
                Console.WriteLine("变量ic1与变量ic2所存储的地址相同!");
            }
            Console.WriteLine(ic1);
            Console.WriteLine(ic2);
            Console.ReadKey();
        }
    }
    class SingleClass
    {
        private static SingleClass singleInstance;//声明一个静态的SingleClass类的变量来引用唯一的对象
        private SingleClass()//创造私有的无参构造方法,使外部无法调用这个类的构造方法
        {

        }
        public static SingleClass SingleMethod()//创建静态方法,创建唯一的对象
        {
            if (singleInstance == null)
            {
                singleInstance = new SingleClass();
            }
            return singleInstance;
        }
    }
}
//单例模式是C#中的一种设计模式,它是指在设计一个类时,需要保证整个程序在运行过程中只存在一个实例对象
//单例模式的特点:
//在类的内部创建一个实例对象,并使静态变量引用该对象,由于变量禁止外部直接访问,因此用private修饰为私有成员
//类的构造方法用private修饰,这样外部就不能用new关键字来创建对象
//为了能在类内部获得类的实例对象,定义一个静态方法,用于返回类的实例
//就是类的构造方法是私有的,所以不能在类外面创建对象,又因为定义静态变量又是私有的,外面也不能访问
//创建静态方法,用静态参数引用静态构造函数创建实例
//在上面的代码中,创建了两个对象,分别将则两个对象的地址存放在ic1和ic2中,使用运算符==判断这两个变量存放的地址是否相同
//结果是相同的,也就是这两个变量指向同一对象,所以只存在一个对象

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //在调用实例构造函数前先调用静态构造函数
            Person p1 = new Person("kyx", 20, 100);
            Person p2 = new Person("kyx", 20, 100);
            Person.StaticFunc();//把上面的注释掉,验证静态方法的调用,此时构造函数也会执行,静态方法依赖于类而不是对象
            Console.WriteLine(p1.age);
            Console.WriteLine(p1.ID);
            Console.WriteLine(p2.age);
            Console.WriteLine(p2.ID);
            Console.ReadKey();
        }
    }
    public class Person
    {
        public static long total = 0;
        string name;
        public const float PI = 3.14f;
        public byte age;
        public long ID;
        static Person()//用static修饰符修饰的构造函数是静态构造函数,用于初始化静态变量,因为构造函数属于类不属于对象,所以静态函数只会被执行一次
        {
            Console.WriteLine("调用静态构造函数,人数为{0}", total);
        }
        public Person(string n, byte a, long i)
        {
            name = n;
            age = a;
            ID = i;
            total++;
            Console.WriteLine("调用实例构造函数,人数为{0}", total);
        }
        public static void StaticFunc()
        {
            Console.WriteLine("静态方法调用!");
            //Person.age = 100;静态方法只能对静态成员赋值
        }
    }
}
//在C#中声明类时,即使没有显式声明构造函数,编译器也会自动添加一个默认的构造函数
//除此之外,可以根据用户需要,创建自己的构造函数.实际上,任何构造函数在执行时都隐式调用了系统提供的默认构造函数base()
//实例构造函数可以被重载,但是不能被继承,因为一个类除了自己的实例构造函数外不会有其他的实例构造函数
//用static修饰符修饰的构造函数是静态构造函数,用户无法像使用普通构造方法那样使用静态构造方法
//静态构造方法会在程序创建第一个实例或者引用任何静态成员之前,完成静态成员的初始化
//用于初始化静态成员或者变量,因为构造函数属于类不属于对象,所以静态函数只会被执行一次
//静态构造函数既没有访问修饰符也没有参数,并且在一个类中只能有一个静态构造函数,它可以和一个无参的构造函数并存
//上面的程序代码中既有静态构造函数,也有实例构造函数.当初始化对象p1时,首先触发静态构造函数执行,通过静态函数初始化类的成员
//然后再执行实例构造函数,并且静态构造函数只会被执行一次
//如果要在不创建对象的情况下就可以调用某个方法,也就是该方法不必和对象绑定在一起
//要实现这样的效果,只需要在类中定义的方法前面加上修饰符static就可以了,称这种方法为静态方法
//同其他静态成员一样,静态方法通过类名.方法名来调用
//类的静态成员函数无法直接访问普通数据成员（可以通过对象名间接的访问），而类的任何成员函数都可以访问类的静态数据成员
//静态成员和类的普通成员一样，也具有public、protected、private3种访问级别，也可以具有返回值、const修饰符等参数
//应用举例：
//汽车制造商为统计汽车的产量，可以在在汽车类--car类中增加用于计数的静态数据成员变量
//比如在某个类car中声明一个static int number; 初始化为0。这个number就能被所有car的实例共用。在//car类的构造函数里加上number++
//在car类的析构函数里加上number--。那么每生成一个car的实例，number就加一，每销毁一个car的实例（汽车报废），number就减一
//这样，number就可以记录//在市场上car的实例个数
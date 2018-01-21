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
            Console.WriteLine("下面这个例子更好的说明类的静态成员");
            Score s1 = new Score(1, "王华", 85, 89, 90);
            Score s2 = new Score(2, "李明", 78, 74, 65);
            Score s3 = new Score(3, "张兵", 82, 89, 82);
            Score s4 = new Score(4, "王超", 65, 98, 72);
            Console.WriteLine("输出平均分结果如下");
            s1.Disp(); s2.Disp(); s3.Disp(); s4.Disp();
            Console.WriteLine("语文平均分:{0} 数学平均分:{1} 英语平均分:{2}",
            Score.Avg1(), Score.Avg2(), Score.Avg3());
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
    class Score             //声明Score类
    {
        int no;             //学号
        string name;        //姓名
        int deg1;           //语文成绩
        int deg2;           //数学成绩
        int deg3;           //英语成绩
        static int sum1 = 0;//语文总分
        static int sum2 = 0;//数学总分
        static int sum3 = 0;//英语总分
        static int sn = 0;  //总人数
        public Score(int n, string na, int d1, int d2, int d3)
        {
            no = n; name = na;
            deg1 = d1; deg2 = d2; deg3 = d3;
            sum1 += deg1;
            sum2 += deg2; sum3 += deg3;
            sn++;
        }
        public void Disp()
        {
            Console.WriteLine("学号:{0} 姓名:{1} 语文:{2} 数学:{3} 英语:{4}" + " 平均分:{5:f}", no, name, deg1, deg2, deg3, (double)(deg1 + deg2 + deg3) / 3);
        }
        public static double Avg1() { return (double)sum1 / sn; }//静态方法
        public static double Avg2() { return (double)sum2 / sn; }//静态方法
        public static double Avg3() { return (double)sum3 / sn; }//静态方法
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
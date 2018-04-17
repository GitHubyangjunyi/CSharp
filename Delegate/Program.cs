using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate//多看C#高级编程的委托示例
{
    class Program
    {
        //声明一个委托，其实就是个“命令”,就是持有一个或多个方法的对象,并且该对象可以执行,可以传递
        //委托可以持有方法,是一种引用类型,既然是类型,就可以实例化对象,可以理解为委托包含一个或多个方法的地址,并且类型安全
        public delegate void BugTicketEventHandler();
        //上面是委托的声明方法
        //static SumDelegate sumd = new SumDelegate(Test.Sum);//也可以放在这,也可以放在下面
        static void Main(string[] args)
        {
            //这里就是具体阐述这个命令是干什么的，本例是MrZhang.BuyTicket“小张买车票”这时候委托被附上了具体的方法
            //注意,声明委托可以不使用delegate关键字
            BugTicketEventHandler myDelegate = new BugTicketEventHandler(MrZhang.BuyTicket);
            //上面的语句声明一个委托并且订阅了小张买票,当使用委托时,小张买票函数就会执行
            myDelegate += MrZhang.BuyMovieTicket;//多播委托
            myDelegate();//使用委托,括号内可以加参数,如果委托有返回值,这可以定义一个变量存放这个委托的返回值
            Console.WriteLine();
            myDelegate -= MrZhang.BuyMovieTicket;
            myDelegate();
            Console.WriteLine();
            myDelegate += () =>
            {
                Console.WriteLine("匿名方法:3.0规范lambda表达式!突然出现一个人去买票!");//lambda表达式
            };
            myDelegate();
            Console.WriteLine();
            myDelegate += delegate ()
            {
                Console.WriteLine("匿名方法:2.0版本的规范匿名方法实现!黄牛把票都买光了!");//lambda表达式
            };
            myDelegate();
            //////////以下是简版委托
            Console.WriteLine("简版委托");
            SumDelegate sumd = new SumDelegate(Test.Sum);//也可以放在这,也可以放在上面面
            int sumnum =sumd(5,6);
            Console.WriteLine();
            sumd += Test.Sum;
            sumd(5, 6);
            Console.WriteLine();
            sumd += Test.Sub;
            sumd(5, 6);
            Console.WriteLine("sumnum=" + sumnum);
            Console.ReadKey();
        }
        //////////以下是简版委托,在类内定义
        public delegate int SumDelegate(int x, int y);//声明一个公共委托,委托有两个参数,找别人做加法
    }
    public class MrZhang
    {   //其实买车票的人物是小张
        public static void BuyTicket()
        {
            Console.WriteLine("让我去买车票！");
        }
        public static void BuyMovieTicket()
        {
            Console.WriteLine("还要让我带电影票！");
        }
    }

    class Test
    {
        public static int Sum(int x, int y)
        {
            Console.WriteLine("x+y=" + (x + y));
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            Console.WriteLine("x-y="+(x-y));
            return x - y;
        }
    }
}
//2.0版本的规范匿名方法
//delegate void del();
//del mydel
//mydel=delegate(){...};
//3.0规范lambda表达式
//mydel=()=>(取代delegate){...};
//简版
//先声明委托
//public delegate int SumDelegate(int x, int y);//声明一个公共委托,委托有两个参数,找别人做加法
//订阅委托
//SumDelegate sumd = new SumDelegate(Test.Sum);//订阅Test类的静态方法Sum
//多播委托
//sumd += Test.Sub;
//int sumnum = sumd(5, 6);//使用委托,括号内可以加参数,如果委托有返回值,这可以定义一个变量存放这个委托的返回值
//因为定义一个委托基本上是定义一个新类,所以可以在定义类的任何地方定义委托
//可以在另外一个类的内部定义,也可以在任何类的外部定义,还可以在名称空间中把委托定义成顶层对象
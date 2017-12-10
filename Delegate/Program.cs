using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        //声明一个委托，其实就是个“命令”,就是持有一个或多个方法的对象,并且该对象可以执行,可以传递
        //委托可以持有方法,是一种引用类型,既然是类型,就可以实例化对象
        public delegate void BugTicketEventHandler();
        //上面是委托的声明方法
        static void Main(string[] args)
        {
            //这里就是具体阐述这个命令是干什么的，本例是MrZhang.BuyTicket“小张买车票”这时候委托被附上了具体的方法
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
            Console.ReadKey();
        }
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
}//2.0版本的规范匿名方法
 //delegate void del();
 //del mydel
 //mydel=delegate(){...};
 //3.0规范lambda表达式
 //mydel=()=>(取代delegate){...};
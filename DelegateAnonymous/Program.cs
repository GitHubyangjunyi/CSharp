using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnonymous//C#高级编程中关于委托的示例,委托匿名方法,下一示例lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            string mid = ",bb";

            Func<string,string> anonDel=delegate(string param)
            {
                param += mid;
                param += ",cc";
                return param;

            };
            Console.WriteLine(anonDel("aa"));
            Console.ReadKey();
        }
    }
}
//匿名方法
//Func<string,string>委托接收一个字符串参数并返回一个字符串
//改代码块使用方法级的字符串变量mid,该变量是在匿名方法的外部定义的,并且把它添加到了要传递的参数中
//使用匿名方法时执行速度并不会加快m,编译器也会定义一个方法并自动指定其名称
//在使用匿名方法时,必须遵守匿名方法的两条规则
//1.匿名方法中不能使用跳转语句break/continue/goto跳到方法的外部
//2.不能使用跳转语句break/continue/goto跳到匿名方法的内部
//在匿名方法的内部不能访问不安全的代码,也不能访问在匿名方法外部使用的ref和out参数,但是可以在匿名方法外部定义其他变量

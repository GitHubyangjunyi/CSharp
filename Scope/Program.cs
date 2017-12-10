using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)//每个C#程序都必须有一个Main方法,它可以在任何一个类中进行定义,且必须被定义为Public static,表示该方法是一个
                                       //全局的静态方法,Main方法的返回值只能是void或int
        {
            int a;
            a = 1;//变量a的作用域在声明它的main方法程序块内，在这个程序块的任何位置都可以使用变量a
            {
                int b = 2;//变量b的作用域是在声明它的{}语句块内，执行{b=2;}后，b的存储空间被释放，后面的语句如果再使用变量b，则会提示错误
                Console.WriteLine(b);
            }
            if (a > 0)
            {
                int c = 3; //变量c的作用域在声明它的if语句块内，在这个语句块外的其他位置在调用这个变量会出错
                a = c * 10;
                Console.WriteLine(a);
            }
            //b = 5;      //错误
            //c = 6;      //错误
        }
    }
}
//C#中没有全局常量和全局变量,一切都属于类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLambda//C#高级编程中关于委托的示例,Lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            string mid = ",bb";

            string Func(string param)
            {
                param += mid;
                param += ",cc";
                return param;

            }
            //Func<string, string> func = param =>//这是lambda表达式
            //{
            //    param += mid;
            //    param += ",cc";
            //    return param;

            //};
            Console.WriteLine(Func("aa"));
            Console.ReadKey();
        }
    }
}
//lambda运算符=>的左边列出了需要的参数,右边定义了赋予lambda表达式变量的方法实现代码
//lambda表达式有几种定义方法,如果只有一个参数,写出参数名就可以了
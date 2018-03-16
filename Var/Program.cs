using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "xxxx";
            var age = 25;
            var isa = true;
            Type nametype = name.GetType();
            Type agetype = age.GetType();
            Type isatype = isa.GetType();
            Console.WriteLine(nametype);
            Console.WriteLine(agetype);
            Console.WriteLine(isatype);
            Console.ReadKey();
        }
    }
}
//类型推断
//使用var关键字声明变量编译器可以根据变量的初始化值推断变量的类型
//推断类型var(C#3.0)其类型由编译器推断,在编译时就已经确定
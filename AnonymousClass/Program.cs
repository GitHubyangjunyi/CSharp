using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建匿名对象
            var Anon = new { Name = "kyx", Age = 20, Sex = "女" };
            Console.WriteLine("我的名字是:{0},性别为{1},年龄是{2}", Anon.Name, Anon.Sex, Anon.Age);
            Console.ReadKey();
        }
    }
}
//有时候某个类的实例只会用到一次可以使用匿名类的方式创建实例即无需显式定义一个类就可以将一组只读属性封装到单个对象中
//会在第十四行创建带有三个只读属性的匿名对象Anon由于匿名类型没有类名,所以这里把Anon声明为var类型编译器会根据匿名类中属性的值来确定属性的类型
//并生成一个类Anon就是一个引用匿名类型的变量同其他类一样所有匿名类均继承自System.Object类
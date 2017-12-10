using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.ShowName();//静态成员不依赖于对象去实现而是依赖于类
            Console.ReadKey();
        }
    }
    public static class StaticClass
    {
        private static string name = "jingkyx";
        public static void ShowName()
        {
            Console.WriteLine("我的名字是" + name);
        }
    }
}
//当类中的所有成员都是静态成员时(只包含静态成员),且不包含示例构造函数,就可以把这个类声明为静态类.在class关键字前面加上static
//静态类的成员并不是默认为静态的,必须用static显示声明为静态成员
//静态类是密封的,不能被继承,不能使用abstract或sealed修饰

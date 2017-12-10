using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum Color
    {
        red = 5, yellow, green
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("red={0}", Color.red);
            Console.WriteLine("red={0}", (int)Color.red);//枚举成员需要经过显式转换才能显示出相应类型的值
            Console.ReadKey();
        }
    }
}
//枚举是一个有命名的值类型的一种特殊形式.枚举的声明主体可以定义0个或多个枚举成员
//名称不能相同,但是多个成员可以共享同一个相关的数值
//默认第一个成员值为零,以此类推
//枚举不能定义自己的方法属性和事件,不能实现接口
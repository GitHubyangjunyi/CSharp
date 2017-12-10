using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            DisArea dis = new DisArea(5);
            ISquare sq = (ISquare)dis;//强制类型转换
            ICircle ci = (ICircle)dis;//强制类型转换
            Console.WriteLine("正方形的面积是:" + sq.Area());//显式接口成员只能通过接口实例访问
            Console.WriteLine("圆形的面积是:" + ci.Area());
            Console.ReadKey();
        }
    }
    interface ICircle
    {
        double Area();//相同签名
    }
    interface ISquare
    {
        double Area();//相同签名
    }
    public class DisArea : ICircle, ISquare
    {
        private float len;
        public DisArea(float l)
        {
            len = l;
        }
        double ICircle.Area()       //显式实现接口
        {
            return len * len;
        }
        double ISquare.Area()       //显式实现接口
        {
            return len * len * Math.PI;
        }
    }
}
//通俗的来讲显示接口实现就是使用接口名称作为方法名的前缀;而传统的实现方式称之为：隐式接口实现
//在实际项目中有时某个类往往会继承多个接口而接口中往往会有一些相同名称、参数与类型的值
//通过显式接口实现可以为避免一些不必要的歧义
//1.当类实现一个接口时通常使用隐式接口实现这样可以方便的访问接口方法和类自身具有的方法和属性
//2.当类实现多个接口时并且接口中包含相同的方法签名此时使用显式接口实现。即使没有相同的方法签名
//仍推荐使用显式接口因为可以标识出哪个方法属于哪个接口
//3.隐式接口实现类和接口都可访问接口中方法显式接口实现只能通过接口访问
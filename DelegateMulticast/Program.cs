using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticast//C#高级编程中关于委托的示例,多播委托,下一示例多播委托出现异常
{
    class Program
    {

        static void Main(string[] args)
        {
            Action<double> operations = MathOperations.MultiplyByTwo;//这里不一样,Action
            operations += MathOperations.Square;
            ProcessAndDisplayNumber(operations,10.0);
            ProcessAndDisplayNumber(operations,100.0);
            ProcessAndDisplayNumber(operations,1000.0);
            Console.ReadKey();
        }
        
        public static void ProcessAndDisplayNumber(Action<double> action, double value)//这里不一样,Action
        {
            Console.WriteLine("ProcessAndDisplayNumber called with value={0}", value);
            action(value);
            Console.WriteLine();
        }
    }

    class MathOperations
    {
        public static void MultiplyByTwo(double value)
        {
            double result = value * 2;
            Console.WriteLine("Multiplying by 2:{0} gives {1}",value,result);
        }

        public static void Square(double value)
        {
            double result = value * value;
            Console.WriteLine("Squareing:{0} gives {1}", value, result);
        }
    }
}
//为了说明多播委托的用法,需要委托引用返回void方法,就应该重写MathOperations类中的方法为void
//也重写ProcessAndDisplayNumber()方法
//通过一个委托调用多个方法还可能导致一个大问题,多播委托包含一个逐个调用的委托集合
//如果通过委托调用的其中一个方法抛出异常,整个迭代就会停止
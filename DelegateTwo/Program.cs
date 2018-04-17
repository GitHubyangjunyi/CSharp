using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTwo//C#高级编程中关于委托的示例,用以领会委托的用处和本质,下一示例关于泛型委托
{
    delegate double DoubleOp(double x);//也可以放在类内

    class Program
    {

        static void Main(string[] args)
        {
            DoubleOp[] operations =//委托数组,自定义的委托
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };

            for (int i = 0; i < operations.Length; i++)//遍历这个委托数组,把每个操作应用到3个不同的值上面,说明了委托的一种使用方式,把方法组合到一个数组中来使用,并在循环中调用不同的方法
            {
                Console.WriteLine("Using operations[{0}]:",i);
                ProcessAndDisplayNumber(operations[i],10.0);
                ProcessAndDisplayNumber(operations[i],100.0);
                ProcessAndDisplayNumber(operations[i],1000.0);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void ProcessAndDisplayNumber(DoubleOp action, double value)//委托数组,自定义的委托
        {
            double result = action(value);
            Console.WriteLine("value is {0},result of operation is {1}",value,result);
        }
    }

    class MathOperations
    {
        public static double MultiplyByTwo(double value)
        {
            return value * 2;
        }

        public static double Square(double value)
        {
            return value * value;
        }
    }
}

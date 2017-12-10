using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPlusPlusAndSubtractSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 12, c;
            c = a++;//等价于c=a;a=a+1;
            Console.WriteLine("c={0},a={1}", c, a);
            c = ++a;//等价于a=a+1;c=a;
            Console.WriteLine("c={0},a={1}", c, a);
            c = b--;//等价于c=b；b=b-1;
            Console.WriteLine("c={0},b={1}", c, b);
            c = --b;//等价于b=b-1;c=b；
            Console.WriteLine("c={0},b={1}", c, b);
            Console.ReadKey();
        }
    }
}
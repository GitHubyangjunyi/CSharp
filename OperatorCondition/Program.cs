using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5, c;
            c = a > b ? a : b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
//上述语句在执行时，首先判断表达式a>b是否成立，如果成立则整个表达式的值为a的值，否则为b的值
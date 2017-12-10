using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorSizeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sizeof(byte));//输出结果为1
            Console.WriteLine(sizeof(short));//输出结果为2
            Console.WriteLine(sizeof(int));//输出结果为4
            Console.WriteLine(sizeof(long));//输出结果为8
            Console.WriteLine(sizeof(float));//输出结果为4
            Console.WriteLine(sizeof(double));//输出结果为8
            Console.WriteLine(sizeof(decimal));//输出结果为16
            Console.WriteLine(sizeof(char));//输出结果为2
            Console.ReadKey();
        }
    }
}
//sizeof运算符可以获取数值型变量在内存中所占的字节数,通过这个运算符可以检索数值类型的大小
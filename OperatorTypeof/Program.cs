using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTypeof
{
    class Program
    {
        static void Main(string[] args)
        {
            Type s = typeof(string);
            Console.WriteLine(s);//输出结果为System.String
            Type i = typeof(int);
            Console.WriteLine(i);//输出结果为System.Int32
            Console.ReadKey();
        }
    }
}
//typeof运算符可以获取指定类型的System.Type对象
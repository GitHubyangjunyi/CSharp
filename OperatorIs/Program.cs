using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorIs
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object obj = i;//装箱转换
            Console.WriteLine(i is int);
            Console.WriteLine(obj is Object);
            Console.ReadKey();
        }
    }
}
//is运算符用于检查对象是否与指定类型相同运算结果为布尔值
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass s = new MyClass();
            int x = s.Add(5);
            int y = s.Add(5, 6);
            int z = s.Add(5, 6, 7);
            Console.WriteLine("x={0},y={1},z={2}", x, y, z);
            int a = s.Add(b:3,a:5,c:4);//命名参数,可以在调用中混合使用位置参数和命名参数
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
    class MyClass
    {
        public int Add(int a, int b = 1, int c = 2)//可选参数列表,可选参数还必须是方法定义的参数的最后参数
        {
            return a + b + c;
        }
    }
}
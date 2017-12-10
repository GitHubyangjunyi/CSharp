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
            Console.ReadKey();
        }
    }
    class MyClass
    {
        public int Add(int a, int b = 1, int c = 2)//可选参数列表
        {
            return a + b + c;
        }
    }
}
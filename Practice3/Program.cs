using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3     //求1!+2!+3!+...+n!
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a = 1;
            int sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                a *= i;
                sum += a;
            }
            Console.WriteLine(a);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRoot2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0, b = 10.0;
            const double epsilon = 0.00001;
            double root = 0.0, residual = 0.0;
            while (b-a>epsilon)
            {
                root=(a+b)/2.0;
                residual = F(root);
                if (residual > 0)
                    b = root;
                else
                    a = root;
            }
                Console.WriteLine("root is" + root);
            Console.ReadKey();
        }
        static double F(double x)
        {
            return x * x - 2.0;
        }
    }
}
//在上一个方法中并没有碰到让二次方程f(x)=x*x-2成立的解,一个较好的办法是搜索其中包含0的最小区间,这一思想源于微积分的均值定理
//0存在于f(x)f(y)<0的区间内
//我们假设f(a)为负数,f(b)是正数,是最初的两个端点a和b,如果区间重点的函数值为负数,用a来表示的左边的端点就会被替换为f((a+b)/2)
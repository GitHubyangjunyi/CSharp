using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assert
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2, c = 6, min;
            min = Order3(ref a, ref b, ref c);
            AssertMsg(min==a,"错误!");
            AssertMsg(a<=b && b<=c, "错误!错误!");
            Console.WriteLine("a="+a+"    b="+b+"    c="+c);
            AssertMsg(false, "错误!错误!错误!");
            Console.ReadKey();
        }
        public static void AssertMsg(bool condition,string msg)//如果布尔表达式的求值结果为false,AssertMsg()就会生产故障诊断输出
        {
            if (!condition)
            {
                Console.WriteLine(msg);
            }
        }
        public static void Order2(ref int p,ref int q)
        {
            int temp = p;
            if (p>q)
            {
                p = q;
                q = temp;
            }
        }
        public static int Order3(ref int a, ref int b,ref int c)
        {
            Order2(ref a,ref b);
            Order2(ref a, ref c);
            Order2(ref b, ref c);
            return a;
        }
    }
}
//断言用于对程序的正确性进行检查,如果违反就强制因出错而退出,断言可以在运行时监视提供故障诊断
//断言是代码片段提供者或者软件厂商和用户之间的一个合同保证,用户需要保证有应用代码的条件,厂商需要保证在这些条件下正确运行
//System.Diagnostics中有一些标准方法用于跟踪调试和断言测试
//对三个变量进行排序并返回最小值第一个断言测试相等性,如果这里发现程序排序错误就打印错误
//第二个断言对着3个变量是否已正确排序进行测试,如果发现程序错误,就打印错误!错误!
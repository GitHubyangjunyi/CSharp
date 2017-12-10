using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 0;
            bool c;
            c = (a > 0 && b != 0);
            Console.WriteLine("c=" + c);//结果为False
            c = (a < 0 && b++ > 1);
            Console.WriteLine("c=" + c);
            Console.WriteLine("b=" + b);
            c = (a != 0 || (b++ < 0));//b++<0不被运行
            Console.WriteLine("c=" + c);//结果为True
            Console.WriteLine("b=" + b);
            c = (a < 0 & b++ >= 0);
            Console.WriteLine("c=" + c);
            Console.WriteLine("b=" + b);
            //c=False
            //c = False
            //b = 0
            //c = True
            //b = 0
            //c = False
            //b = 1
            //运算符“&”和“&&”都表示“与”操作,当且仅当运算符两边的操作数都为true时,其结果才是true
            //在使用“&”进行运算时,不论左边为true或者false，右边的表达式都会进行运算
            //如果使用“&&”进行运算,当左边为false时，右边的表达式不会进行运算因此“&&”被称为“短路与”||同理
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 5;
            Console.WriteLine("a/b={0}", a / b);//如果运算量都为整形数值时，运算的结果会将小数部分舍去（不进行四舍五入运算）
            Console.WriteLine("a/b={0}", (float)a / b);//如果想要使两个整形运算量的除法运算结果为浮点数，需要把其中一个运算量显式转换成浮点型
            Console.ReadKey();
        }
    }
}
//除法默认不保留小数点,decimal z=10/100;z=0;
//如果需要保留小数点,则decimal z=10m/100;z=0.1;m代表decimal
//或者把它显式转换,把被除数显式转换加上(decimal)
//int x=3,y=6;
//float z=x/y;z会等于0
//因为会先进行int的除法操作,再把值0赋给z
//float x=3,y=6;
//float z=x/y;z会等于0
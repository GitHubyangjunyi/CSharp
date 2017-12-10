using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConverting2
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 12.3456;
            int i;
            i = (byte)d;
            //i = d;这会报错
            Console.WriteLine("d={0}", d);
            Console.WriteLine("i={0}", i);
            //显示转换可能会发生信息的丢失和引发异常
            //(1)对于从一个整形到另一个整形的转换,编译器会进行溢出检查,如果没有发生溢出则转换成功,否则引发OverflowException异常
            //(2)对于从float,double或decimal到整形的转换,源数据舍入到最接近的整形值,如果超出目标的取值范围会引发OverflowException异常
            //(3)对于从double到float的转换,double值舍入到最接近float值,如果double值太小,则结果为正0或负0
            //如果double值过大,则结果为正无穷大或负无穷大;如果值为NaN,结果还是NaN
            //(4)对于从float或double到decimal的转换,源数据转换成decimal形式,并舍入到小数点后28位,如果源数据太小或者为无穷或者为NaN,则会引发OverflowException异常
            //(5)对于从decimal到float或double的转换,decimal舍入到最接近float或double的值,这种转换会损失精度,但不会发生异常
            Console.ReadKey();
        }
    }
}
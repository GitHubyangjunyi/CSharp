using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object obj = i;//装箱转换
            i = 15;
            Console.WriteLine("i={0},obj={1}", i, obj);
            obj = 20;
            Console.WriteLine("i={0},obj={1}", i, obj);
            Console.ReadKey();
        }
    }
}
//拆箱和装箱机制是发生在值类型和引用类型相互转换过程中的
// 装箱机制是将值类型隐式转换为object（对象）类型，或者转换为任何该值类型所执行的接口类型
//上述语句执行时，首先会为int型变量i在内存栈中分配空间，经过装箱转换后，变量i的值10存放到了内存堆中
//声明的object型变量obj在内存栈中分配空间，但是其指向i堆上的int型数值10.所以变量i和装箱副本是相互独立的
//实际开发中,某些方法的参数类型为引用类型,如果调用时传入的的是值类型,就需要装箱操作
//同样当一个方法的返回值类型是值类型是,但实际方法返回值为引用类型,这时需要拆箱操作
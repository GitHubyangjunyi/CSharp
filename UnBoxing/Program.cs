using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object obj = i;//装箱转换
            i = 15;
            int j = (int)obj;//拆箱转换
            Console.WriteLine("i={0},obj={1},j={2}", i, obj, j);
            obj = 20;
            Console.WriteLine("i={0},obj={1},j={2}", i, obj, j);
            j = 30;
            Console.WriteLine("i={0},obj={1},j={2}", i, obj, j);
            Console.ReadKey();
        }
    }
}
//拆箱是将object类型转换为值类型或者是把任意接口类型转换成执行该接口的值类型的过程
//拆箱转换需要执行显式转换这也是拆箱转换与装箱转换不同的地方
//上述语句在执行拆箱转换时先会检查obj的实例值是否与指定装箱值得数据类型匹配如果满足拆箱的条件则将内存堆中的数据10赋值给int型变量j
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params//params参数可以让方法在调用时传入任意个类型相同的参数,定义方法时不需要确定参数的个数
                //这时可以使用数组作为方法的参数,并在数组参数前面加上params关键字,并且不能与ref和out组合使用
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFunc(1, 2, 3, 4);
            Console.ReadKey();
        }
        public static void TestFunc(params int[] array)//定义个数可变的参数就是在一个数组参数前面加上params关键字
        {                                             //在方法调用时就可以简单地将任意个数的参数放在方法后面的括号里
            for (int i = 0; i < array.Length; i++)   //实现向方法里传入任意个参数的功能,但在一个方法中只能有一个params参数
            {                                       //并且只能放在方法的最后
                Console.WriteLine(array[i]);//循环打印数组中的数据
            }
        }
    }
}
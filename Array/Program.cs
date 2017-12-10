using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr;          //声明int型一维数组arr
            //string[] str;       //声明str型一维数组str
            //声明数组时指定数组元素的完整内容
            //int[] arr = {1,2,3,4,5};
            //声明数组时指定数组的大小，然后使用关键字new初始化所有数组元素
            //int[] arr =new int[5];使用这种方法初始化的数组根据数据类型都有一个统一的默认值0
            //上面的语句也可以改写成
            //int [] arr;
            //arr=new int[5];
            //可以使用变量初始化数组
            //int i=5;
            //int[] arr=new int[i];
            //使用组合方式初始化数组
            //int[] arr=new int[i]{1,2,3,4,5};
            //使用这种方式初始化数组时，要注意数组的大小必须要与元素的个数相同，另外使用这种方式初始化数组时不能使用变量初始化数组大小
            //下面是错误的；
            //int i=5;
            //int[] arr=new int[i]{1,2,3,4,5};
            //如果将变量声明为常量，就是正确的
            //int i=5;
            //int[] arr=new int[i]{1,2,3,4,5};//正确
            //string类型变量可以看作char类型变量的只读数组，所以也可以通过数组的方式访问字符串变量的每个字符
            //string str="C# Program";
            //char ch=str[6];
            //Console.WriteLine(ch);
            string str = "C# Program";
            char ch = str[0];
            Console.WriteLine(ch);
            Console.ReadKey();
        }
    }
}
//在C中不允许对二维和二维以上的多维数组的部分元素初始化
//在C#中数组和字符串都能自动进行边界检查和长度计算
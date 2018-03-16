using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
            long l = i;//int类型隐式转换成long类型
            Console.WriteLine("i={0},l={1}", i, l);
            int num = 4;
            short b = (short)num;//强制类型转换才不会编译错误
            Console.WriteLine(b);
            //一个int型（四个字节）的值赋给short类型（两个字节）变量b时int类型的取值范围大于short的取值范围，会导致数值溢出
            //隐式转换也叫自动类型转换条件一：彼此兼容条件二目标类型的取值范围大于源类型的取值范围
            //如条件不成立必须进行强制类型转换
            //目标类型 变量 =（目标类型）值
            Console.WriteLine("x={0:F2}", 123456789);//输出浮点数,小数点占用两位
            Console.WriteLine("x={0:F4}", 123456789);//输出浮点数,小数点占用四位
            int a = 'a';
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
//==整数类型
//有符号sbyte    一个字节    8位有符号的整数
//      short    两个字节    16位有符号的整数
//      int      四个字节    32位有符号的整数
//      long     八个字节    64位有符号的整数
//无符号byte     一个字节    8位无符号的整数
//      ushort   两个字节    16位无符号的整数
//      uint     四个字节    32位无符号的整数
//      ulong    八个字节    64位无符号的整数
//字符类型char如'a'  '/uAOB1'u表示Unicode
//==实数类型
//单精度float
//双精度double    提供15位精度,且浮点数默认double,若要使用float就必须写成1.23F
//==十进制类型decimal
//==布尔类型bool只有true和false不能用0或1代替
//==字符串类型string是引用类型,但是对字符串常量有特殊处理
//==推断类型var(C#3.0)其类型由编译器推断,在编译时就已经确定
//    var a = 1+2;
//==Nullable类型(C#3.0)
//    int? a = 32;
//    if(a.HasValue)...判断a是不是有值
//==Dynamic(C#4.0)由DLR支持,编译时不进行检查,运行时才确定,主要用于COM组件或其他语言交互
//    dynamic x = new Cell();
//的基本预定义类型并没有内置于C龉言中而是内置于.NET Framwork中例如,声明一个int类型的数据时
//实际上是.NET结构System.Int32的一个实例
//这听起来似乎很深奥,但其意义深远:这表示在语法上,可以把所有的基本数据类型看作是支持某些方法的类
//应强调的是,在这种便利语法的背后,类型实际上仍存储为基本类型,在概念上用.NET结构表示所以肯定没有性能损失
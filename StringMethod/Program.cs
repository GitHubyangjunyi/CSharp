using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //String strtest = "test";
            string str1 = "    Welcome to Beijing!    ";//字符串常量前后各有4个空格
            Console.WriteLine("{0}:{1}", str1, str1.Length);//Length属性可以获取字符串长度即字符串中包括空格在内字符的个数是字符串对象唯一的属性
            string str2 = str1.Trim();//Trim()方法可以去掉字符串两端的空格
            Console.WriteLine("{0}:{1}", str2, str2.Length);
            string str3 = str2.ToUpper();//ToUpper()方法可以将字符串中的小写字母转换成大写字母
            Console.WriteLine(str3);
            string str4 = str2.ToLower();//ToLower()方法可以将字符串中的大写字母转换成小写字母
            Console.WriteLine(str4);
            string str5 = string.Copy(str2);//静态方法Copy()可以进行字符串复制
            Console.WriteLine(str5);
            string str6 = str2.Substring(0, 6);//Substring()方法可以返回一个从指定位置开始且具有指定长度的字符串
            Console.WriteLine(str6);
            String str7 = str2.Substring(10);//Substring()方法可以返回一个从指定位置开始并直到末尾的字符串
            Console.WriteLine(str7);
            ////////////////////////////////////////
            Console.WriteLine("////////////////////////////////////////");
            string s1 = "a string";
            string s2 = s1;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            s1 = "b string";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
//尽管这是一个值类型的赋值,但string是一个引用类型
//string对象被分配在堆上,而不是栈上
//因此,当把一个字符串变量赋予另一个字符串时,会得到对内存中同一个字符串的两个引用
//但是,字符串是不可改变的,修改其中一个字符串,就会创建一个全新的string对象,而另一个字符串不发生任何变化这实际上是运算符重载的结果
//string对象是不可改变的,每次使用string中的方法都会在内存中创建一个新的字符串对象,增大系统开销这时候就可以使用
//StringBuilder类以提高性能
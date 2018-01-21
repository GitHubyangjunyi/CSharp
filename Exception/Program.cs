using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 10;
                int num2 = 0;
                int num3 = num1 / num2;
                Console.WriteLine("num3=" + num3);
            }
            catch (DivideByZeroException e)//带对象的catch代码块:catch后面不仅带有异常类型,还带有异常对象,通过异常对象获取异常信息
            {
                Console.WriteLine("已处理异常信息:" + e.Message);
                //Console.ReadKey();
                return;
            }
            catch (SystemException)//特定的catch代码块:catch后面带有异常类型,匹配该类型的所有异常
            {
                Console.WriteLine("已处理系统异常!");
                return;
            }
            catch//一般的catch代码块:catch后面没有任何内容,可以匹配任何类型的异常
            {
                Console.WriteLine("已处理异常!");
                return;
            }
            finally
            {
                Console.WriteLine("finally代码块被执行!");
                Console.ReadKey();
            }
            //throw new Exception("这是一个异常!");
        }
    }
}
//在C#中提供了大量的异常类,这些类都继承自Exception类,每个类都代表一个指定的异常类型
//每个异常都包含一些只读的属性:
//属性                类型      描述
//Message           string      解释异常原因的消息
//StackTrace        string      异常发生的位置信息
//InnerException    Exception   如果当前异常是另一个异常引起的,此属性包含前一个异常的引用
//HelpLink          string      为异常原因信息提供URN或URL
//Source            string      含有异常起源所在的程序集的名称
//可以使用多个catch块对异常进行捕获,但只有一个catch块可以捕获到异常,并且是按catch代码块的顺序进行捕获
//所以将带有异常对象的catch块放在第一位,依次类推
//希望程序无论是否发生异常都要执行,可以再try...catch语句后加上finally代码块
//在所有catch代码块中增加return,用于结束当前方法,而finally代码块还是会执行,例如用来释放系统资源
//在使用异常语句时,try代码块必须有,而catch代码块和finally代码块必须要有一个,否则编译错误
//还可以使用throw关键字抛出异常对象,throw new Exception("这是一个异常!");抛出一个异常
//throw关键字只会抛出一个异常对象,不会对异常进行处理,抛给上层代码处理,如果一直不处理,最后会被操作系统捕捉到
//一般将throw和try...catch配合使用
//如果出现异常,那么后面的代码块将不会执行
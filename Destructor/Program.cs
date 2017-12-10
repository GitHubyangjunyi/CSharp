using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
        }
    }
    public class Student
    {
        public Student()
        {
            Console.WriteLine("执行一次构造函数!");
        }
        ~Student()//析构函数既没有修饰符也没有参数,所以不能被重载,也不能被继承,析构函数是被自动调用的,所以不能被显式调用
        {        //用于释放类的实例,回收对象所占用的资源析构函数于类名相同,前面加了个运算符~
            Console.WriteLine("执行一次析构函数!");
            //在一个类中只能有一个析构函数,在函数体中包含了销毁类的实例时要执行的语句
        }
    }
}
//请使用开始执行不调试
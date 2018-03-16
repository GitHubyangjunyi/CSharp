using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("杨俊艺", 20);
            Console.ReadKey();
        }
    }
    public class Student
    {
        public Student()
        {
            Console.WriteLine("无参的构造方法");
        }
        public Student(string name) : this()    //通过this关键字调用无参的构造方法
        {
            Console.WriteLine("一个参数的构造方法");
        }
        public Student(string name, int age) : this("杨俊艺")    //通过this关键字调用一个参数的构造方法
        {
            Console.WriteLine("两个参数的构造方法");
        }
    }
}
//构造方法在实例化时会被.Net运行环境自动调用,因此不能像调用其他方法一样调用构造方法,但可以用":this(参数一,参数二...)"的形式调用其他的构造方法
//先调用了Student类中带有两个参数的构造方法,在此构造方法中通过this关键字调用了包含一个参数的构造方法,然后在带有一个参数的构造方法调用了无参构造方法,注意调用顺序和执行顺序
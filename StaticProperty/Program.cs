using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.intNo = 10;
            Student s = new Student();
            s.Name = "kyx";
            s.Age = 20;
            Console.WriteLine("Student.intNo={0}", Student.Counter);//只有大写Counter,小写私有的
            Console.WriteLine("s.Name={0}", s.Name);
            Console.WriteLine("s.Age={0}", s.Age);
            Student.intNo = 30;//要想改变静态字段的值,只能通过类名.静态字段名来对它重新赋值
            Student ss = new Student();
            ss.Name = "kyx2";
            ss.Age = 22;
            Console.WriteLine("Student.intNo={0}", Student.Counter);//只有大写Counter,小写私有的,这个和输出引用是不一致的
            Console.WriteLine(Student.intNo);
            Console.WriteLine("ss.Name={0}", ss.Name);
            Console.WriteLine("ss.Age={0}", ss.Age);
            Console.ReadKey();
        }
    }
    class Student
    {
        public static int intNo;//公共静态字段,如果把静态属性修饰符static注释掉,那么主函数的第一句就会报错
        private string name;   //私有实例字段
        private int age;      //私有实例字段
        private static int counter = 0;//私有静态字段
        public string Name
        {
            get { return name; }//可读写实例属性
            set { name = value; }
        }
        public int Age
        {
            get { return age; }//可读写实例属性
            set { age = value; }
        }
        public Student()//构造函数
        {
            counter = ++counter + intNo;
        }
        public static int Counter
        {
            get { return counter; }//只读静态属性
        }
    }
}
//静态属性可以实现静态只读变量的作用,并且不用初始化变量,也不用保存,随时调用
//注意:在静态属性的get函数中不能使用this关键字,不然会出错
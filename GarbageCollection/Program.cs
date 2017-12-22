using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.Name = "kyx";
            s2.Name = "kyx";
            s2 = null;
            GC.Collect();//通知运行环境执行垃圾回收.
            Console.ReadKey();
        }
    }
    public class Student
    {
        public string Name
        {
            get;
            set;
        }
        ~Student()//析构函数,在对象被销毁时自动调用.
        {
            Console.WriteLine(Name + ":资源被回收了!");
        }
    }
}
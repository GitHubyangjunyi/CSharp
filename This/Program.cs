using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p2 = new Person(12);
            p2.Say();
            p2.Test();
            //void Say()
            //{
            //    Console.WriteLine("大家好!");
            //}
            //Say();
            Console.ReadKey();
        }
    }
    public class Person
    {
        public int Age
        {
            get;
            set;
        }
        public Person(int Age)//构造方法的参数被定义为Age,是一个局部变量,在类中还定义了一个Age属性
        {                     //在构造方法中如果使用Age是访问局部变量,如果使用this.Age是访问属性
            this.Age = Age;//this表示对当前实例的引用,this注释掉又有不同的结果,将导致对象的年龄赋值无果,始终为0
        }
        public void Test()
        {
            Console.WriteLine("这是一个测试方法!");
            this.Say();
        }
        public void Say()
        {
            int Age = 0;
            Age = Age + 1;
            Console.WriteLine("大家好,我今年" + this.Age + "岁了!");
            Console.WriteLine("大家好,我今年" + Age + "岁了!");
        }
    }
}
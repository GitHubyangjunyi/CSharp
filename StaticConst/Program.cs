using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConst
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("杨俊艺");
            Console.WriteLine("ID={0}", p1.ID);
            Console.WriteLine("count={0}", Person.count);//静态常量的访问需要像访问静态成员一样,但是在声明常数时不需要使用static
            Console.WriteLine("name={0}", p1.name);      //在声明常量时关键字const前的修饰符可以使用new,public,protected,internal,private
            Person p2 = new Person("kyx", 123456);
            Console.WriteLine("ID={0}", p2.ID);
            Console.WriteLine("count={0}", Person.count);
            Console.WriteLine("name={0}", p2.name);
            //Person.count = 2;//无法赋值给静态常量
            Console.ReadKey();
        }
    }
    public class Person
    {
        public const int count = 1;//静态常量
        public string name;       //实例字段
        public int ID;           //实例字段
        public Person(string n)
        {
            name = n;
            ID = count;
        }
        public Person(string n, int ID)//构造函数,函数重载
        {
            name = n;
            this.ID = ID;
        }
    }
}
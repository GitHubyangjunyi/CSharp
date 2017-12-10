using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("杨俊艺", 22);
            Console.WriteLine("name={0}", p1.name);
            Console.WriteLine("age={0}", p1.age);
            //p1.age = 18;不能在此修改只读字段的值,只能在声明他的位置和构造函数中对他赋值
            //p1.name = "kyx";不能在此修改只读字段的值,只能在声明他的位置和构造函数中对他赋值
            Console.ReadKey();
        }
    }
    public class Person
    {
        public readonly string name = "null";//只读字段
        public readonly int age = 0;        //只读字段
        public Person(string n, int i)
        {
            name = n;//在构造函数中对只读字段赋值
            age = i;//在构造函数中对只读字段赋值
        }
    }
}
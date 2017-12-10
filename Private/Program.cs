using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("杨俊艺", 22, 350681);
            p.Display();
            Console.ReadKey();
        }
    }
    public class Person
    {
        private String name;
        private int age;
        private long ID;
        //public int number;//当你调用p.的时候会显示出来,private修饰的则不会,只能通过构造函数Person赋值
        public Person(string n, int a, long i)//构造函数
        {
            name = n;
            age = a;
            ID = i;
        }
        public virtual void Display()
        {
            Console.WriteLine("name={0}", name);
            Console.WriteLine("age={0}", age);
            Console.WriteLine("ID={0}", ID);
        }
    }
}
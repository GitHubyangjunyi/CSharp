using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog
            {
                Name = "沙皮狗"
            };
            dog.Shout();
            dog.PrintName();
            dog.Shouts();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public string Name
        {
            get;
            set;
        }
        public Animal()
        {
            Console.WriteLine("Animal的构造方法被执行!");
        }
        public void Shout()
        {
            Console.WriteLine("动物叫!");
        }
        public void Shouts()
        {
            Console.WriteLine("Animal的Shouts方法!");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog的构造方法被执行!");
        }
        public void PrintName()
        {
            Console.WriteLine("name=" + Name);
        }
        public new void Shouts()
        {
            Console.WriteLine("Dog的Shouts方法!");
        }
    }
}

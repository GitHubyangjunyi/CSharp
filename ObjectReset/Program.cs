using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectReset
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "kyx", Age = 20, Gender = '女' };
            Console.WriteLine("我的名字是:" + p1.Name + "年龄是:" + p1.Age + "性别为" + p1.Gender);
            Console.ReadKey();
        }
    }
    class Person
    {
        int age;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        char gender;
        public char Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
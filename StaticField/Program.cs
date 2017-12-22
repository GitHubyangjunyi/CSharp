using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("杨俊艺");
            Console.WriteLine("ID={0}", p1.ID);
            Console.WriteLine("count={0}", Person.count);//静态字段属于类本身,而不属于某个对象.无论生成多少个对象,对静态字段的访问必须通过类
            Console.WriteLine("name={0}", p1.name);      //静态字段在类的实例间共享,而实例字段属于类的某个特定实例
            Person p2 = new Person("kyx");
            Console.WriteLine("ID={0}", p2.ID);
            Console.WriteLine("count={0}", Person.count);
            Console.WriteLine("name={0}", p2.name);
            Console.ReadKey();
        }
    }
    public class Person
    {
        public static int count = 1;//静态字段
        public string name;        //实例字段
        public int ID;            //实例字段
        public Person(string n)  //构造函数
        {
            name = n;
            count++;
            ID = count;
        }
    }
}
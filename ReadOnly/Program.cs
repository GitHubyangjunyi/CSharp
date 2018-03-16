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
        public Person(string n, int i)//readonly对属性无效
        {
            name = n;//在构造函数中对只读字段赋值
            age = i;//在构造函数中对只读字段赋值
        }
    }
}
//常量的概念就是一个包含不能修改的值的变量,但是有时候需要一些变量,值不应改变,但是运行之前值是不确定的,这就需要只读变量
//其规则是可以在构造函数中给只读字段赋值但不能在其他地方赋值,只读字段还可以是一个实例字段,而不是静态字段,类的每个实例可以有不同的值,与const字段不同,如果要把只读字段设置为静态,必须显示声明
//比如一个用于编辑文档的软件,限制可以同时打开的文档数,不同的版本有不同的限制,显然不能在源代码中硬编码最大文件数
//把这个字段设置为只读,每次启动都从注册表键或者从其他文件中读取
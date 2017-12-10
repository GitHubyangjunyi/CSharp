using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();//当对象被实例化后,可以通过对象的引用来访问对象的成员
            p1.Say();
            p1 = null;//当没有任何变量引用这个对象时,它将成为垃圾对象,不能再被使用
            p1.Say();//null是一个特殊的常量,当一个变量的值为null时,表示该变量不指向任何一个对象,被p1引用的Person对象失去引用,成为垃圾对象
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void Say()
        {
            Console.WriteLine("接下来引发异常!");
        }
    }
}
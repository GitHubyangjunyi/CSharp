using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            foreach (char c in str)
            {
                Console.Write(c + "\t");
            }
            Console.ReadKey();
        }
    }
}
//foreach(类型 变量名称in集合名对象)
//{
//语句块
//}
//执行foreach语句时，首先要声明循环变量。这个变量是一个局部变量，它的作用范围只在freach语句内
//这个变量的作用是依次存放要遍历的集合对象中的各个元素，但并不更改这些元素的内容
//循环体中，这个变量的值也不能被赋予其他的新值
//循环不可能出现计数错误, 也不可能越界
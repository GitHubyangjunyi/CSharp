using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X= N1;
namespace Namespace//命名空间作为文件组织形式
{
    class Program
    {
        static void Main(string[] args)
        {
            X::A oa = new X::A();
            oa.Myls();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("{0}", args[i]);
            }
            Console.ReadKey();
        }
    }
}
namespace N1
{
    class A
    {
        public void Myls()
        {
            Console.WriteLine("挺漂亮的!");
            Console.ReadKey();
        }
    }
}
//调用方法时使用命名空间.类名.方法名
//在C#程序中,,可以创建多个命名空间,实例程序中定义了项目名称的命名空间,这是IDE自动用项目名称创建的
//在这个命名空间内定义的类必须包含在{}中,如果在同一项目的其他程序中使用这个类
//可以直接使用全名或者引用其命名空间
//using关键字的另一功能是给类和命名空间指定别名
//using namespacexxx=namespaceyyy;
//命名空间别名修饰符为::
//如果在同一个作用域内引入了一个X类就会发生冲突,即时发生了冲突,::也允许使用别名
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserName
{
    class Program
    {
        static void Main(string[] args)
        {
            string uName, pwd;
            Console.WriteLine("请输入用户名：");
            uName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            pwd = Console.ReadLine();
            if (uName == "admin" && pwd == "123456")
            {
                Console.WriteLine("用户名和密码输入正确！");
            }
            else
            {
                Console.WriteLine("用户名和密码输入错误！");
            }
            Console.ReadKey();
        }
    }
}
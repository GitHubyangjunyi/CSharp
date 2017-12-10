using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("请输入分数");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 10:
                case 9: Console.WriteLine("优"); break;
                case 8: Console.WriteLine("良"); break;
                case 7: Console.WriteLine("中"); break;
                case 6: Console.WriteLine("及格"); break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0: Console.WriteLine("不及格"); break;
                default: Console.WriteLine("请输入0到10的数字！"); break;
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int i = rd.Next(0, 10000) % 100 + 1; //1到100之间的数，可任意更改
            int c = 0;
            int x;
            while (true)
            {
                Console.WriteLine("请输入你猜的数字：");
                int j = Convert.ToInt32(Console.ReadLine());
                c++;
                if (j > i)
                    Console.WriteLine("你猜的数字太大了！");
                else
                    if (j < i)
                    Console.WriteLine("你猜的数字太小了！");
                else
                {
                    Console.WriteLine("恭喜你猜对了！你一共猜了{0}次!", c);
                    switch (c)
                    {
                        case 1: Console.WriteLine("神一般的玩家!"); break;
                        case 2: Console.WriteLine("你很厉害!"); break;
                        case 3: Console.WriteLine("运气不错!"); break;
                        case 4: Console.WriteLine("玩的还行!"); break;
                        case 5: Console.WriteLine("玩的还行!"); break;
                        case 6: Console.WriteLine("玩的还行!"); break;
                        case 7: Console.WriteLine("一般人水平!"); break;
                        default: Console.WriteLine("你会不会玩!"); break;
                    }
                    Console.WriteLine("想不想再玩一局！是请输入1并按下回车键，否请输入0并按下回车键");
                    x = Convert.ToInt32(Console.ReadLine());//重新随机
                    i = rd.Next(0, 10000) % 100 + 1;
                    c = 0;
                    if (x == 0)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
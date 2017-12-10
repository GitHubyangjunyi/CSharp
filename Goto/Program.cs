using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;
            loop:
            sum += i;
            i++;
            if (i <= 100)
            {
                goto loop;
            }
            Console.WriteLine("1加到100={0}", sum);
            Console.ReadKey();
        }
    }
}
//goto语句是一个无条件的跳转语句，它的一般形式如下
//goto 语句标号
//其中，语句标号是一个有效标识符，它可以出现在程序的某个位置，用冒号：与语句分隔开
//执行goto语句时，程序将跳转到语句标号所在的位置，并执行它后面的语句
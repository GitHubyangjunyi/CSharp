using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("输入范围:");
            string data = Console.ReadLine();
            n = int.Parse(data);
            bool[] sieve = new bool[n];
            int i;
            Console.WriteLine("");
            for ( i = 0;  i < sieve.Length;  i++)
            {
                sieve[i] = true;
            }
            for (int j = 2; j < Math.Sqrt(n); j++)
            {
                if (sieve[j])
                {
                    CrossOut(sieve,j,j+j);
                }
            }
            for ( i = 2; i < sieve.Length; i++)
            {
                if (sieve[i])
                {
                    Console.WriteLine(" "+i);
                }
            }
            Console.ReadKey();
        }
        public static void CrossOut(bool [] s,int interval,int start)
        {
            for (int i = start; i < s.Length; i+=interval)
            {
                s[i] = false;
            }
        }
    }
}
//假设要找出2到100之间的素数,根据埃拉托色尼过滤算法,指定一个布尔类型的数组,其中含有100个元素,全部初始化为true
//从数组[2]开始,使用其索引值2,并继续针对其余数组元素,
//埃拉托色尼筛选法(the Sieve of Eratosthenes)简称埃氏筛法，是古希腊数学家埃拉托色尼(Eratosthenes 274B.C.～194B.C.)
//提出的一种筛选法。 是针对自然数列中的自然数而实施的，用于求一定范围内的质数，它的容斥原理之完备性条件是p=H~。
//（1）先把1删除（现今数学界1既不是质数也不是合数）
//（2）读取队列中当前最小的数2，然后把2的倍数删去
//（3）读取队列中当前最小的数3，然后把3的倍数删去
//（4）读取队列中当前最小的数5，然后把5的倍数删去
//（5）如上所述直到需求的范围内所有的数均删除或读取
//注：此处的队列并非数据结构队列，如需保留运算结果，处于存储空间的充分利用以及大量删除操作的实施，建议采用链表的数据结构。
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueMinValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sbyte型的最大值为：{0}，最小值为：{1}\n", sbyte.MaxValue, sbyte.MinValue);
            Console.WriteLine("byte型的最大值为：{0}，最小值为：{1}\n", byte.MaxValue, byte.MinValue);
            Console.WriteLine("short型的最大值为：{0}，最小值为：{1}\n", short.MaxValue, short.MinValue);
            Console.WriteLine("ushort型的最大值为：{0}，最小值为：{1}\n", ushort.MaxValue, ushort.MinValue);
            Console.WriteLine("int型的最大值为：{0}，最小值为：{1}\n", int.MaxValue, int.MinValue);
            Console.WriteLine("uint型的最大值为：{0}，最小值为：{1}\n", uint.MaxValue, uint.MinValue);
            Console.WriteLine("long型的最大值为：{0}，最小值为：{1}\n", long.MaxValue, long.MinValue);
            Console.WriteLine("ulong型的最大值为：{0}，最小值为：{1}\n", ulong.MaxValue, ulong.MinValue);
            Console.ReadKey();
        }
    }
}
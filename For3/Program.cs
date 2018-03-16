using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, s = 0;
            for (i = 2; i < 6; i++, i++)
            {
                s = 1;
                for (j = i; j < 6; j++)
                    s += j;
            }
            Console.WriteLine("{0}", s);
        }
    }
}
//简直坑爹
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -1,-33,5,3,67,44,23,55};
            foreach(int e in a)
                Console.WriteLine(e);
            Sort(a);
            foreach (int e in a)
                Console.WriteLine(e);
            Console.ReadKey();
        }
        static void Swap(int [] date,int first,int second)
        {
            int temp;
            temp = date[first];
            date[first] = date[second];
            date[second] = temp;
        }
        static int Min(int[] date, int start, int end)
        {
            int indexOfMin = start;
            for (int i = start+1; i <=end; ++i)
            {
                if (date[i]<date[indexOfMin])
                {
                    indexOfMin = i;
                }
            }
            return indexOfMin;
        }
        static void Sort(int[] date)
        {
            int next, indexOfNext;
            for (next = 0; next < date.Length-1; ++next)
            {
                indexOfNext = Min(date,next,date.Length-1);
                Swap(date,indexOfNext,next);
            }
        }
    }
}

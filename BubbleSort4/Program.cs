using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortArray = { 2, 3, 1, 5, 6, 9, 7, 8, 4, 0 };
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            foreach (var item in sortArray)
            {
                Console.Write(item);
                Console.Write("\t");
            }
            Console.ReadKey();
        }
    }
}

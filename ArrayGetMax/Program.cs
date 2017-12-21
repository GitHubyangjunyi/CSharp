using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayGetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 5, 6, 6, 7, 8, 9, 10, 11 }; //排好序为下面的查找指定元素下标的函数
            int[] arrtest = { 1,2,3,4,5,6,7 };
            int max = GetMax(arr);
            Console.WriteLine("max=" + max);
            //int max2 = GetMax(1,6,55);
            //Console.WriteLine("max2=" + max2);
            Console.WriteLine("//========================================//");
            int index = LinearSearch(arr,11);
            Console.WriteLine("查找的值在数组中的下标为:"+index);
            int index2 = BinarySearch(arrtest, 3);
            Console.WriteLine("查找的值在数组中的下标为:"+index2);
            int index3 = BinarySearch(arr, 11,0,arr.Length);
            Console.WriteLine("查找的值在数组中的下标为:" + index3);
            Console.ReadKey();
        }
        public static int GetMax(/*params这个关键字注释掉会导致max2这一行报错,该关键字可以传入任意个参数*/int[] arr)
        {
            int max = arr[0];//一般初始化第一个元素为最大值
            for (int x = 1; x < arr.Length; x++)
            {
                if (arr[x] > max)
                    max = arr[x];
            }
            return max;
        }
        static int LinearSearch(int[] key, int v)//线性查找法
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == v)
                    return i;
            }
            return -1;
        }
        static int BetterLinearSearch(int[] key, int v)//优化版只要有一个值大于v就停止查找
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == v)
                    return i;
                else if (key[i] > v)
                    return -1;
            }
            return -1;
        }
        static int BinarySearch(int[] key, int v)//二分查找法对于n个元素的数组,最多需要lg(n)次
        {
            int position;
            int begin = 0, end = key.Length - 1;
            while (begin<=end)//等于号很重要,比如遇到只有两个元素的数组或者只有一个元素的数组或者数组元素个数特殊的情况下
            {
                position = (begin + end) / 2;
                if (key[position] > v)
                {
                    end = position - 1;
                }
                else if (key[position] < v)
                {
                    begin = position + 1;
                }
                else
                    return position;
            }
            return -1;
        }
        static int BinarySearch(int[] key, int v, int begin, int end)//递归方法重写的二分查找法,函数重载
        {
            int position = (begin + end) / 2;
            if (begin<=end)//等于号很重要,比如遇到只有两个元素的数组或者只有一个元素的数组或者数组元素个数特殊的情况下
            {
                if (key[position] == v)
                {
                    return position;
                }
                else if (key[position] < v)
                {
                    return BinarySearch(key, v, position+1, end);
                }
                else
                {
                    return BinarySearch(key, v, begin, position - 1);
                }
            }
            return -1;
        }
        static int[] MinMax(int[] key)//获取最大值和最小值
        {
            int[] minMax = new int[2];//存放最小值和最大值
            int midPoint = key.Length / 2;
            for (int i = 0; i < midPoint; i++)
            {
                if (key[i]>key[midPoint+i])
                {
                    Swap(i, midPoint + i,key);
                }
            }
            minMax[0] = key[0];
            for (int i = 1; i < midPoint; i++)
            {
                if (key[i]<minMax[0])
                {
                    minMax[0] = key[i];
                }
            }
            minMax[1] = key[midPoint];
            for (int i = midPoint+1; i < key.Length; i++)
            {
                if (key[i]>minMax[1])
                {
                    minMax[1] = key[i];
                }
            }
            return minMax;
        }
        static void Swap(int i,int j,int[] key)
        {
            int temp = key[i];
            key[i] = key[j];
            key[j] = temp;
        }
    }
}
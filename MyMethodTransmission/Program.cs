﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyMethodTransmission
{
    class Program
    {
        public static void ValueType(int x)     //含有一个值类型的形参
        {
            x++;
        }
        public static void ReferenceType(ref int x) //含有一个引用类型的形参
        {
            x++;
        }
        public static void OutType(int x, int y, out int add, out int sub)  //含有两个输出形参
        {
            add = x + y;
            sub = x - y;
        }
        public static int ParamsType(params int[] array)    //含有一个数组形参
        {
            int i, sum = 0;
            for (i = 0; i < array.Length; i++) sum += array[i];
            return sum;
        }
        public static double ParamsType(params double[] array)	//重载方法ParamsType
        {
            double sum = 0, mean = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            mean = sum / array.Length;
            return mean;
        }
        static void Main(string[] args)
        {
            Console.Title = " chpt4-3";
            int a = 5;
            Console.WriteLine("调用ValueType方法前a={0}", a);
            ValueType(a);
            Console.WriteLine("调用ValueType方法后实参a={0}", a);
            ReferenceType(ref a);
            Console.WriteLine("调用ReferenceType 方法后实参a={0}", a);
            int x = 10, y = 3, sum, dif;
            OutType(x, y, out sum, out dif);
            Console.WriteLine("调用OutType方法后sum={0},dif={1}", sum, dif);
            int[] b = { 1, 4, 6, 9, 15 };		//含有5个元素的一维数组
            sum = ParamsType(b);
            Console.WriteLine("数组b = [1, 4, 6, 9, 15]的元素之和为{0}", sum);
            sum = ParamsType(2, 4, 6, 8);		//只传递了4个int型的值
            Console.WriteLine("2, 4, 6, 8之和为{0}", sum);
            double mean = ParamsType(1.5, 5.4, -0.6, 8.2, -2);//只传递了5个double型的值
            Console.WriteLine("重载方法ParamsType后1.5, 5.4, -0.6, 8.2, -2的平均值为{0}", mean);
            Console.ReadLine();
        }
    }
}
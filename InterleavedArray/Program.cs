using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterleavedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jArr = new int[3][];
            jArr[0] = new int[5];
            jArr[1] = new int[4];
            jArr[2] = new int[2];
            Console.WriteLine("输入数组元素");
            for (int i = 0; i < jArr.Length; i++)
            {
                Console.WriteLine("第{0}个数组的元素", i + 1);
                for (int j = 0; j < jArr[i].Length; j++)
                {
                    jArr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("按行输出数组元素");
            for (int i = 0; i < jArr.Length; i++)       //二维交错数组中，各个数组元素的长度是不同的
            {
                for (int j = 0; j < jArr[i].Length; j++)//通过i的变化取得各个数组元素的长度
                {
                    Console.Write(jArr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("使用foreach语句输出全部数组元素");
            foreach (int i in jArr[0])
            {
                Console.Write(i + "\t");
            }
            foreach (int i in jArr[1])
            {
                Console.Write(i + "\t");
            }
            foreach (int i in jArr[2])
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(jArr.Length);//输出3，三维交错数组
            Console.ReadKey();
        }
    }
}
//交错数组
//交错数组是用数组作为元素的数组，交错数组元素的维度和大小可以不同，所以交错数组有时称为“数组的数组”
//二维交错数组的声明和初始化
//数据类型[][]数组名称
//交错数值必须初始化才能使用。因为交错数组的每一行包含的元素的个数不同，所以在初始化交错数组时，只要在第一个方括号中设置该交错数组包含的行数
//第二个方括号为空。二维交错数组的初始化需要对每一个子数组都进行初始化，即每一个子数组的初始化都由独立的一条语句来完成
//int[][]jArr=new int[3][];
//jArr[0]=new int[5];
//jArr[1]=new int[4];
//jArr[2]=new int[2];
//在上面的代码中，jArr是由3个一维int型数组组成的交错数组。第一个元素是由5个整数组成的数组，第二个元素是由4个整数组成的数组
//第三个元素是由2个整数组成的数组。也可以使用下面的语句
//jArr[0]=new int[]{1,2,3,4,5};
//jArr[1]=new int[]{11,12,13,14};
//jArr[2]=new int[]{21,22};
//还可以在声明数组时将其初始化
//int[][]jArr=new int[][];
//{
//    new int[]{1,2,3,4,5};
//    new int[]{11,12,13,14};
//    new int[]{21,22};
//};
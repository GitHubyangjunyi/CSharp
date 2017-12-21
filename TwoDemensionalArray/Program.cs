using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDemensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            Console.WriteLine("输入数组元素的值");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("请输入第{0}行元素值", i + 1);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("将二维数组元素的值以矩阵的形式输出");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("使用foreach语句将二维数组元素的值输出");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.ReadKey();
        }
    }
}
//在C中不允许对二维和二维以上的多维数组的部分元素初始化,数组中单个的元素在分配时会自动初始化,C#是唯一具有多维数组类型的程序语言
//并允许任意类型的数组,包括由数组构成的数组,利用两对方括号就可以获得一个交错的二维数组
//double[][] up;//二维数组
//char [] [] [] a;//三维数组
//C#还具有真正的矩阵多维数组,每一个维度用一个逗号来指定
//double [ , ] matrix;
//int [ , , ,] plane;
//基本数据类型初始化为0,布尔型初始化为false,其他引用类型全部初始化为特殊值null
//数组是一个集合类型或者说是对象类型,关联了方法和特殊成员,在C#中数组和字符串都能自动进行边界检查和长度计算尽量使用数组长度这一属性去作为循环条件
//避免出现"相差1"这样的隐式错误,如数组为空或元素个数为一以及漏掉第一个元素
//C#按引用来传递数组参数,数组属于引用类型,应把数组变量看作是对数组地址的引用,传递给方法的是地址而不是数组的值
//之所以采用这种方法是因为数组一般很大,这样可以加快程序的执行
//由于传递的是数组引用所以可以用方法来改变数组的值,这叫副作用
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr;          //声明int型一维数组arr
            //string[] str;       //声明str型一维数组str
            //声明数组时指定数组元素的完整内容
            //int[] arr = {1,2,3,4,5};
            //声明数组时指定数组的大小，然后使用关键字new初始化所有数组元素
            //int[] arr =new int[5];使用这种方法初始化的数组根据数据类型都有一个统一的默认值0
            //上面的语句也可以改写成
            //int [] arr;
            //arr=new int[5];
            //可以使用变量初始化数组
            //int i=5;
            //int[] arr=new int[i];
            //使用组合方式初始化数组
            //int[] arr=new int[i]{1,2,3,4,5};
            //使用这种方式初始化数组时，要注意数组的大小必须要与元素的个数相同，另外使用这种方式初始化数组时不能使用变量初始化数组大小
            //下面是错误的；
            //int i=5;
            //int[] arr=new int[i]{1,2,3,4,5};
            //如果将变量声明为常量，就是正确的
            //const int i=5;
            //int[] arr=new int[i]{1,2,3,4,5};//正确
            //string类型变量可以看作char类型变量的只读数组，所以也可以通过数组的方式访问字符串变量的每个字符
            string str = "C# Program";
            char ch = str[6];
            Console.WriteLine(ch);
            int[] date1 = new int[5] { 1,2,3,4,5};
            int[] date2 = new int[3] { 6,7,8};
            int sum1 = Sum(date1);
            int sum2 = Sum(date2);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            int sum3 = 0;
            foreach (int e in date1)
            {
                sum3 += e;
            }
            Console.WriteLine(sum3);
            Console.WriteLine("////////////////////////////////////////");
            System.Collections.ArrayList st = new ArrayList();
            st.Add(89); st.Add(58); st.Add(85);
            st.Add(72); st.Add(69); st.Add(92);
            st.Add(76); st.Add(82); st.Add(96);
            st.Sort();
            st.Reverse();
            int i = 1;
            foreach (int item in st)
            {
                Console.WriteLine("第{0}名: {1}", i, item);
                i++;
            }
            Console.ReadKey();
        }
        static int Sum(int[] a)//对数组进行计算时应该将其封装为一个方法,数组传进去搞定,不同类型使用重载
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
//数组是引用类型,所以是对象
//在C中不允许对二维和二维以上的多维数组的部分元素初始化,数组中单个的元素在分配时会自动初始化,C#是唯一具有多维数组类型的程序语言
//并允许任意类型的数组,包括由数组构成的数组的叫做交错数组,利用两对方括号就可以获得一个交错的二维数组
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
//C#提供了一个ArrayList类（该类位于命名空间System.Collections中）,它实际上是Array数组类的优化版本,区别在于ArrayList类提供了大部分集合类具有而Array类没有的功能
//ArrayList是一个可以包含任意数组的集合,使用大小可按需动态增加。ArrayLis在实际使用中,你会发现ArrayList是一个可以包含不同数据类型、不同元素个数、大小可以任意调整的数组集合,非常适于描述结构层次复杂的数据结构,有点像结构体,但使用更灵活
//定义ArrayList类的对象的语法格式如下：
//ArrayList 数组名 = new ArrayList([初始容量]);
//例如，以下语句定义一个ArrayList类的对象myarr，可以将它作为一个数组使用：
//ArrayList myarr = new ArrayList();
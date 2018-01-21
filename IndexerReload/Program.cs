using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerReload
{
    class Program
    {
        public static int size = 10;
        private string[] namelist = new string [size];
        public Program()
        {
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N.A";
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index > 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }
            set
            {
                if (index > 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
        public int this[string name]//设置索引器
        {
            get
            {
                int index = 0;//定义初始下标为0
                while (index<size)//下标是否小于数组元素个数
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;//如果条件不成立,下标加一并进入下一次判断
                }
                return index;//如果不存在的话返回下标最大值+1,也就是越界值
            }
        }
        static void Main(string[] args)
        {
            Program names = new Program();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            // 使用带有 int 参数的第一个索引器
            for (int i = 0; i < Program.size; i++)
            {
                Console.WriteLine(names[i]);
            }
            // 使用带有 string 参数的第二个索引器
            Console.WriteLine(names["Nuha"]);
            Console.ReadKey();

        }
    }
}
//索引器Indexer可被重载,索引器声明的时候也可带有多个参数,且每个参数可以是不同的类型,没有必要让索引器必须是整型的
//C#允许索引器可以是其他类型,例如,字符串类型
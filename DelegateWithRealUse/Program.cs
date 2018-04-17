using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateWithRealUse//C#高级编程中关于委托的示例,用以领会委托的用处和本质,本示例关于泛型委托的真正用法
//请按照基本冒泡排序法-封装的冒泡排序法-使用泛型委托进行冒泡排序-然后再想为什么SortTTest<T>(IList<T> sortArray)这个方法无意义
//因为类型没有定义比较方法或者称为比较规则
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortArray = { 2, 3, 1, 5, 6, 9, 7, 8, 4, 0 };
            BubbleSorter.Sort(sortArray);
            foreach (var item in sortArray)//输出语句放这里为了验证数组是否真正排序完成
            {
                Console.Write(item);
                Console.Write("\t");
            }
            Console.WriteLine();
            //我们希望这个方法不仅适合int类型的排序,虽然我自己改成封装的方法就够呛
            //而且能给任何对象排序,换言之如果客户端代码包含自定义的其他类和结构的数组,但是这个方法只对int有效,通用性不高
            //所以能识别该类的客户端代码必须在委托中传递一个封装的方法,而这个方法可以进行比较
            //另外不给temp变量使用int类型,而使用泛型类型就可以实现泛型方法
            //对于接收T的泛型犯法SortT<T>()需要一个比较方法,其两个参数的类型是T,这个方法可以从Func<T1,T2,TResult>委托中引用
            //其中T1,T2类型相同:Func<T,T,bool>
            Employee[] employees =
            {
                new Employee("A",3000),
                new Employee("B",5000),
                new Employee("C",1500),
                new Employee("D",3000),
                new Employee("E",4500),
                new Employee("F",1000),
                new Employee("G",2500),
            };
            BubbleSorter.SortT(employees,Employee.CompareSalary);//把方法当参数传递进去
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

    class BubbleSorter
    {
        public static void Sort(Array sortArray)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if ((int)sortArray.GetValue(i) > (int)sortArray.GetValue(i + 1))
                    {
                        int temp = (int)sortArray.GetValue(i);
                        sortArray.SetValue((int)sortArray.GetValue(i + 1), i);
                        sortArray.SetValue(temp, i+1);
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        //comparison必须引用一个方法,该方法带有两个参数,如果第一个参数的值"小于"第二个参数,返回true
        static public void SortT<T>(IList<T> sortArray, Func<T, T, bool> comparison)
        //IList<T>表示可按照索引单独访问的对象的集合
        //为了匹配Func<T, T, bool>委托的签名,在这个类中必须定义CompareSalary,参数是两个引用,并返回一个布尔值
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Count-1; i++)
                {
                    if (comparison(sortArray[i+1], sortArray[i]))//调用当参数传进去的方法进行比较,感觉向函数指针,但比函数指针类型安全,未验证的想法
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i+1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static public void SortTTest<T>(IList<T> sortArray)//因为泛型并没有定义比较方法,所以这个方法无效,详情看报错点
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    //if (sortArray[i] > sortArray[i + 1])//这里报错
                    //{
                    //    T temp = sortArray[i];
                    //    sortArray[i] = sortArray[i + 1];
                    //    sortArray[i + 1] = temp;
                    //    swapped = true;
                    //}
                }
            } while (swapped);
        }
    }

    class Employee
    {
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name,decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public static bool CompareSalary(Employee e1, Employee e2)
        {
            return e1.Salary < e2.Salary;
        }

        public override string ToString()
        {
            return string.Format("{0},{1:C}",Name,Salary);
        }
    }
}
//以下冒泡排序法在BubbleSort4项目下有
//            int[] sortArray = { 2, 3, 1, 5, 6, 9, 7, 8, 4, 0 };
//            bool swapped = true;
//            do
//            {
//                swapped = false;
//                for (int i = 0; i<sortArray.Length-1; i++)
//                {
//                    if (sortArray[i]>sortArray[i + 1])
//                    {
//                        int temp = sortArray[i];
//                        sortArray[i] = sortArray[i + 1];
//                        sortArray[i + 1] = temp;
//                        swapped = true;
//                    }
//                }
//            } while (swapped);
//            foreach (var item in sortArray)
//            {
//                Console.Write(item);
//                Console.Write("\t");
//            }
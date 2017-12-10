using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolClass xg = new SchoolClass(50);
            xg[1] = "第一个学生";
            xg[2] = "第二个学生";
            Console.WriteLine(xg[1]);
            Student s = new Student();
            s[1] = "kyx";
            s[2] = "女";
            s[3] = "1234567890";
            s.Say();
            Student b = new Student();
            b[1] = "xxx";
            b[2] = "男";
            b[3] = "0987654321";
            b.Say();
            Console.ReadKey();
        }
    }
    class SchoolClass
    {
        private string[] student;
        public SchoolClass(int n)//班内学生数
        {
            student = new string[n + 1];//学号从1开始
        }
        public string this[int ID]//声明索引器
        {
            get { return student[ID]; }
            set { student[ID] = value; }
        }
    }
    public class Student
    {
        private string name;
        private string sex;
        private string tel;
        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 1:
                        return name;
                    case 2: return sex;
                    case 3: return tel;
                    default:
                        throw new ArgumentOutOfRangeException("index");//抛出异常
                }
            }
            set
            {
                switch (index)
                {
                    case 1:
                        name = value;
                        break;
                    case 2:
                        sex = value;
                        break;
                    case 3:
                        tel = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("index");//抛出异常
                }
            }
        }
        public void Say()
        {
            Console.WriteLine("我叫" + this[1] + ",我是" + this[2] + "生,我的电话号码是:" + this[3]);
        }
    }
}
//通常情况下,属性只能访问单一字段,如果想访问多个数据成员,就需要使用索引器
//索引器是类的特殊成员,它可以根据索引在多个数据成员间进行选择
//索引器也称为下标指示器,它是C#语言提供的一个给对象元素编写下标的索引指示器
//对于类中包含的数组型对象,利用索引器可以通过对象的元素的下标访问对象的各个元素
//索引器与属性类似,在声明索引器时也要使用get和set访问函数,但是在声明索引器时不需要给出名称,而是使用this关键字引用当前对象实例
//声明索引器一般格式如下:
//[修饰符] 数据类型 this [索引类型 index]
//{
//    get{返回参数值}
//    set{设置隐式参数value给字段赋值}
//}
//在上述语句中,使用this关键字加[索引类型 index]的形式创建一个索引器,在索引器中同样会使用get和set访问器,来获取属性值和设置属性值
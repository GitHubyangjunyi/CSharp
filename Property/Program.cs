using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("kyx", 123456, 18, "女")
            {
                Age = -30,//字段在赋值时不能进行有效的控制,应该对字段的访问进行限制,使用属性,看下面
                Gender = "很好看"
            };
            stu.Introduce();
            Console.ReadKey();
        }
    }
    public class Student
    {
        private string name = "张三";//定义了三个私有字段name,intNo和age,对外界提供了相应的属性
                                   //其中属性Name,IntNO和Age用于封装name,intNo和age字段,Gender为自动属性
        public string Name//定义了公有属性Name用于封装name
        {
            get { return name; }//只读属性
        }
        private int intNo;
        public int IntNo//定义了公有属性IntNo用于封装intNo
        {
            get { return intNo; }//只读属性
        }

        private int age;
        public int Age//定义了公有属性Age用于封装age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("年龄不合法!");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Gender//定义表示性别的自动属性
        {
            get;
            set;
        }
        public void Introduce()
        {
            Console.WriteLine("大家好,我叫" + name + ",我是" + intNo + "号,我今年" + age + "岁!我是" + Gender + "的!");
        }
        public Student(string nam, int num, int ag, string gen)
        {
            name = nam;
            intNo = num;
            age = ag;
            Gender = gen;
        }
    }
}
//声明类的属性成员的一般格式为:
//  class 类名
//  {
//      [修饰符] 数据类型 属性名
//      {
//          访问体函数
//      }
//  }
//其中修饰符可以是new,public,protected,internal,private,static,virtual,sealed,override,abstract和extern
//如果修饰符是abstract,说明属性的访问器是抽象的,没有提供访问器的实际实现,则访问体中只包含一个;号
//如果使用extern,说明这个属性为外部属性,不提供实际的实现,所以每个访问器声明都只有一个分号
//属性访问器由两个部分组成:get函数和set函数
//get函数是一个不带参数的方法,用于对属性值的读操作(访问字段)
//set函数带有简单值类型参数的方法,用于对属性值的写操作(修改字段)
//格式如下:
//[修饰符] get {访问体}
//[修饰符] set {访问体}
//在get函数中,主要使用return或throw语句返回,某个变量成员的值
//set函数由一个特殊的关键字value,它是set函数的隐式参数.在set函数中通过value参数传递数据,并赋值给变量成员
//在类中,一个属性不一定同时有get和set,则两个函数是否存在决定了这个属性是只读属性还是只写属性,或是读写属性
//类中最好不要用public或protected的实例字段,避免将字段直接公开,而应采用private,通过属性访问器来对类进行版本控制
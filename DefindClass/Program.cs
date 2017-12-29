using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefindClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zhangsan = new Student();
            zhangsan.SetValue(1, "张三", 'M');//参数1不会生效,详情看下面
            zhangsan.Print();
            Student lisi = new Student();   //类的实例化是通过关键字new创建的,创建后类的实例是一个引用类型的变量.访问成员通过运算符.实现
            lisi.intNo = 100;              //类名 实例名=new 类名(参数);
            lisi.Print();                 //new Student()用于创建Student类的一个实例对象
            Student wangwu = new Student();//Student zhangsan = new Student();
            wangwu.intNo = 11111;          //Student zhangsan则是声明了一个Student类型的变量zhangsan
            wangwu.Print();             //中间等号用于将Person对象在内存中的地址赋值给变量p,这样变量p便持有了Person对象的引用
                                        //三个对象分别是独立的个体,分别拥有各自的intNo字段//Person myTest=new Person("LiFei",25,001);
                                        //或者
                                        //Person myTest;
                                        //myTest=new Person("LiFei",25,001);
            Console.ReadKey();
        }
    }
    public class Student//声明一个Student类
    {
        public int intNo;  //类的数据成员,包括常量和字段,常量是与该类相关的常量值,字段就是该类的变量,如intNo
        public string name;//定义在类中的变量称为字段--------在方法中的称为局部变量
        public char ChrSex;//                                                           
        public void SetValue(int i, string s, char c)//函数成员   
        {
            //int intNo = 8;//这句不注释掉学号为0,因为不赋值自动为0,char类型自动赋值'\0'也就是空格                                  
            name = s;
            ChrSex = c;
        }
        public void Print()//函数成员,公有方法,外部可以访问.用这个方法可以访问到intNo,name,ChrSex
        {
            //int intNo = 60;如果这一句不注释掉,下面的intNo就变成局部变量而不是字段,鼠标放上去会显示intNo是局部变量,值就变成60不会显示1
            Console.WriteLine("学号:{0},性别:{1},姓名{2}", intNo, ChrSex, name);//
        }
    }
}
//类的声明结束
//在声明类时,可以在关键字class前面使用修饰符.类的修饰符可以是下面的修饰符之一或者他们的组合,但是在定义类时同一修饰符是不允许出现多次的
//(1)new:仅允许在嵌套类声明中使用,表示所修饰的类会将继承下来的同名成员隐藏起来
//(2)internal:内部类,默认情况下类的声明是内部的,即只有当前项目中的代码才能访问它
//(3)public:公共类,表示对这个类的访问不受限制
//(4)protected:受保护的类,表示只能从所在类和所在类派生的子类进行访问
//(5)private:私有类,表示只能由该类访问
//(6)abstract:抽象类,表示该类不能被实例化,只能继承
//(7)sealed:密封类,表示该类只能实例化,不能被继承
//参照以修饰符命名的示例程序
//函数成员是执行操作的方法,主要有一下几种:
//(1)方法成员:实现该类可执行的操作
//(2)属性成员:定义命名特征以及读取和写入这些特征的操作
//(3)事件成员:定义由该类生成的消息
//(4)构造函数:定义初始化该类的实例时需要进行的操作
//(5)析构函数:定义在永久放弃该类的一个实例前需要进行的操作
//(6)索引成员:可以使该类的实例按照与数组相同的方式进行索引
//(7)运算符成员:定义表达式运算符,使用它对该类的实例进行运算
//在声明类时,可以使用访问修饰符限定类的成员的访问级别
//(1)public:公共成员,访问不受限制,最高访问级别
//(2)internal:内部成员,只限定于当前项目访问
//(3)protected:受保护成员,仅限当前类或当前类派生的类访问
//(4)private:私有成员,只能在声明该成员的类中访问,最低访问级别
//类和结构体的区别:
//类和结构体都是.NET Framework中常规类型系统中的两种基本构造.两者在本质上都属于数据结构,封装着一组整体作为一个逻辑单元的数据和行为
//数据和行为是该类或结构体的"成员",它们包含各自的方法,事件和属性等
//类或结构体的声明类似于图纸,用于在运行时创建实例或对象.如果定义一个名为Person的类或结构体,则Person为类型名称
//如果声明并初始化Person类型的变量p,p称为Person的对象或实例
//可以创建同一Person类型的多个实例,每个实例在其属性和字段中具有不同的值
//类是一种"引用类型".创建类的对象时,对象赋值到的变量只保存对该内存的引用.将对象引用赋给新变量时,新变量引用的是原始对象
//通过一个变量做出的更改将反映在另一个变量中,因为两者引用同一数据
//结构体是一种"值类型".定义结构体后,声明的该结构体变量保存实际数据
//将结构体赋给新变量时,将复制该结构.因此,新变量和原始变量包含同一数据的两个不同副本.对一个副本的更改不影响另一个副本
//类通常用于对复杂的行为建模,或对要在创建类对象后进行修改的数据建模
//结构体最适合一些小型数据结构,这些数据结构包含的数据以创建后不修改的数据为主
//结构与类的区别是它们在内存中的存储方式、访问方式
//类class是存储在堆heap上的引用类型
//结构struct是存储在栈stack上的值类型和它们的一些特征(如结构不支持继承)

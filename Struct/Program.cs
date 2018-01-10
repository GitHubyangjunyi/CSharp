using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Book//结构类型声明应放在Main方法外面
{
    public string bookName;//访问权限主要取值有public和private（默认值），public表示可以通过该类型的变量访问该字段，private表示不能通过该类型的变量访问该字段,使用private会报错
    public string authorName;
    public float price;
    public string publisher;
    public override string ToString()//重写结构体的ToString()方法
    {
        //return base.ToString();
        return string.Format("书名{0},作者{1},价格{2},出版社{3}", bookName, authorName, price, publisher);
    }
}

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1;//声明一个book型变量
            //为变量b1成员赋值
            b1.bookName = "Math";
            b1.authorName = "Deng gang";
            b1.price = 30;
            b1.publisher = "AAA";
            Console.WriteLine(b1.ToString());
            Console.WriteLine("\n\t图书信息\n");
            Console.WriteLine("书名：{0}\n", b1.bookName);
            Console.WriteLine("作者：{0}\n", b1.authorName);
            Console.WriteLine("价格：{0}\n", b1.price);
            Console.WriteLine("出版商：{0}\n", b1.publisher);
            Book[] books = new Book[5];
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("");
                books[i].bookName = Console.ReadLine();
            }
            Console.WriteLine(books[4].bookName);
            Console.ReadKey();
        }
    }
}
//一个新结构的变量可以用关键字new来创建,也可以不用new关键字创建,这样不会调用此结构的任何构造函数
//相反,通过结构变量名字直接给数据成员赋值时,必须初始化所有数据成员
//不能通过属性或方法进行初始化,以为在初始化成员之前,没有一个数据成员能够被调用,所以必须声明为public
//结构类型为值类型,而相似的类为引用类型
//结构与类的区别是它们在内存中的存储方式、访问方式(类是存储在堆heap上的引用类型)
//而结构是存储在栈stack上的值类型和它们的一些特征如结构不支持继继承
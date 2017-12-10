using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Book
{
    public string bookName;
    public string authorName;
    public float price;
    public struct Publisher
    {
        public string name;
        public string phone;
        public string address;
    }
}
namespace StructInStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1;         //声明一个Book型变量
            b1.bookName = "Math";
            b1.authorName = "Deng gang";
            b1.price = 30;
            Book.Publisher p1;//声明一个Publisher型变量
            p1.name = "AAA";
            p1.phone = "12345678";
            p1.address = "Beijing";
            Console.WriteLine("\n\t图书信息\n");
            Console.WriteLine("书名：{0}\n", b1.bookName);
            Console.WriteLine("作者：{0}\n", b1.authorName);
            Console.WriteLine("价格：{0}\n", b1.price);
            Console.WriteLine("\n\t出版社信息\n");
            Console.WriteLine("出版社名称：{0}\n", p1.name);
            Console.WriteLine("出版社电话：{0}\n", p1.phone);
            Console.WriteLine("出版社地址：{0}\n", p1.address);
            Console.ReadKey();

        }
    }
}
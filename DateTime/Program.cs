using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(2017, 11, 11);
            Date dd = new Date();
            Console.WriteLine("第一次调用简版");
            dd.Print(1);
            Console.WriteLine("第二次调用详细版");
            d.Print();
            Console.ReadKey();
            Console.WriteLine(System.DateTime.Now);
            Console.ReadKey();
        }
    }
    class Date
    {
        public int year;
        public int month;
        public int date;
        public int hour;
        public int minute;
        public int second;
        public Date(int year, int month, int date)
        {
            this.year = year;
            this.month = month;
            this.date = date;
        }
        public Date()
        {
            this.year = System.DateTime.Now.Year;
            this.month = System.DateTime.Now.Month;
            this.date = System.DateTime.Now.Day;
            this.hour = System.DateTime.Now.Hour;
            this.minute = System.DateTime.Now.Minute;
            this.second = System.DateTime.Now.Second;

        }
        public void Print()
        {
            Console.WriteLine(year + "年" + month + "月" + date + "日" + System.DateTime.Now.Hour + "时" + System.DateTime.Now.Minute + "分" + System.DateTime.Now.Second + "秒");
        }
        public void Print(int i)
        {
            Console.WriteLine(year + "年" + month + "月" + date + "日");
        }
    }
}
//DateTime结构位于System命名空间中，DateTime值类型表示值范围在公元0001年1月1日午夜12:00:00到公元9999年12月31日晚上11:59:59之间的日期和时间。//可以通过以下语法格式定义一个日期时间变量：//DateTime 日期时间变量 = new DateTime(年, 月, 日, 时, 分, 秒);//例如，以下语句定义了2个日期时间变量：//DateTime d1 = new DateTime(2015, 10, 1);
//DateTime d2 = new DateTime(2015, 10, 1, 8, 15, 20);
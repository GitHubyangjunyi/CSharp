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
            dd.print(1);
            Console.WriteLine("第二次调用详细版");
            d.print();
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
        public void print()
        {
            Console.WriteLine(year + "年" + month + "月" + date + "日" + System.DateTime.Now.Hour + "时" + System.DateTime.Now.Minute + "分" + System.DateTime.Now.Second + "秒");
        }
        public void print(int i)
        {
            Console.WriteLine(year + "年" + month + "月" + date + "日");
        }
    }
}

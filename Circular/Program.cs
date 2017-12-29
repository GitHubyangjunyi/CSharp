using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularClass R = new CircularClass(2);
            Console.WriteLine("半径为2的圆的面积是:" + R.Mj());
            Ball B1 = new Ball(5);
            Console.WriteLine("半径为5的球面积是:" + B1.Mj());
            B1.Tj();
            Ball B2 = new Ball();
            Console.WriteLine(B2.Mj());
            B2.Tj();
            YZ yz1 = new YZ(6, 2);
            Console.WriteLine(yz1.Mj());
            yz1.Tj();
            Console.WriteLine("请输入半径r:");
            double x = Convert.ToDouble(Console.ReadLine());
            CircularClass RX = new CircularClass(x);
            Ball BX = new Ball(x);
            Console.WriteLine("圆的面积是:" + RX.Mj());
            Console.WriteLine("球的面积是:" + BX.Mj());
            BX.Tj();
            Console.WriteLine("是否要求圆柱的表面积和体积?是请输入高的值,否请输入0退出!");
            double h = Convert.ToDouble(Console.ReadLine());
            if (h == 0)
            {
                return;
            }
            else
            {
                YZ YZX = new YZ(x, h);
                Console.WriteLine("圆柱的面积是:" + YZX.Mj());
                YZX.Tj();
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
    class CircularClass
    {
        protected double r;
        protected double s;
        //protected double S
        //{
        //    get;
        //    set;
        //}
        protected double v;
        //protected double V
        //{
        //    get;
        //    set;
        //}
        public CircularClass()
        { }
        public CircularClass(double r)
        {
            this.r = r;
            this.s = r * r * 3.14;
        }
        public virtual double Mj()
        {
            //Console.WriteLine("圆的面积是:"+s);
            return s;
        }
    }
    class Ball : CircularClass
    {
        public Ball()
        {

        }
        public Ball(double r)//:base(r)这是不是废话,如果没有定义无参的构造函数,就需要使用:base(r)避免报错.
        {
            this.s = 4 * r * r * 3.14;
            this.v = (4 / 3.0) * r * r * r * 3.14;
        }
        public override double Mj()
        {
            //Console.WriteLine("球的面积是:" +this.s);
            return s;
        }
        public void Tj()
        {
            Console.WriteLine("球的体积是:" + this.v);
        }
    }
    class YZ : CircularClass
    {
        //protected double h;
        public YZ()
        {

        }
        public YZ(double r, double h)//:base(r)这是不是废话,如果没有定义无参的构造函数,就需要使用:base(r)避免报错.
        {
            this.s = 2 * 2 * r * 3.14 + h * 2 * 3.14 * r;
            this.v = r * r * 3.14 * h;
        }
        public override double Mj()
        {
            //Console.WriteLine("圆柱的面积是:" +this.s);
            return this.s;
        }
        public void Tj()
        {
            Console.WriteLine("圆柱的体积是:" + this.v);
        }
    }
}
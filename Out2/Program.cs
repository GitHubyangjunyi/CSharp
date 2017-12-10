using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out2
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个double数组
            double[] arr = { 1.2, 1, 2.2, 3, 4, 5.5, 6, -19, -1, 20, 19, 17.8 };
            double max, min, avg;
            //调用GetValues方法,使用out参数实现引用传递
            GetValues(arr, out max, out min, out avg);
            Console.WriteLine("max={0},min={1},avg={2}", max, min, avg);
            int x = 2, y = 3;
            int sum, power;
            calc(x, y, out sum, out power);
            Console.WriteLine(sum);
            Console.WriteLine(power);
            Console.ReadKey();
        }
        //定义了求最大值最小值和平均值的方法
        public static void GetValues(double[] nums, out double max, out double min, out double avg)
        {
            double sum = 0;
            min = nums[0];
            max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (max < nums[i]) max = nums[i];
                if (min > nums[i]) min = nums[i];
            }
            avg = sum / nums.Length;
        }
        public static void calc(int x, int y, out int z, out int w)
        {
            z = x + y;
            w = x * y;
        }
    }
}
//输出参数和引用参数类似的地方是都不为形参创建新的存储位置,在方法中对输出参数的操作都会影响实参
//两者不同的是,调用带有输出参数的方法之前,不需要对传递给形参的实参初始化,方法调用完成后,实参变量会被方法中的形参赋值
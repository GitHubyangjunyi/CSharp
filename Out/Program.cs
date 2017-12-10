using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out                      //out参数必须在方法内赋值
{
    class Program
    {
        static void Main(string[] args)
        {
            string uid = "admin";
            string pwd = "777777";//密码为888888,程序会提示密码错误
                                  //定义变量但不需要初始化
            if (CheckLogin(uid, pwd, out string msg))
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("登录失败,错误原因是" + msg);
            }
            Console.ReadKey();
        }
        //定义CheckLogin()方法,检查用户名密码是否正确
        public static bool CheckLogin(string uid, string pwd, out string msg)//out后面的参数值会保存,用于传递方法或函数返回的数据,而不能向方法或函数传入数据
        {
            if (uid == "admin" && pwd == "888888")
            {
                msg = null;             //out修饰的参数不能初始化,必须带回数据,不然会报错
                return true;
            }
            else
            {
                msg = "用户名或密码错误";
                return false;
            }
        }
    }
}
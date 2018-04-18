using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulticastException
{
    class Program
    {
        delegate void DelegateError(); 

        static void Main(string[] args)
        {
            DelegateError delegateError = new DelegateError(One);
            delegateError += Two;
            try
            {
                delegateError();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught");
            }
            Console.WriteLine("应使用迭代列表来避免这个问题");
            Action action = One;
            action += Two;
            Delegate[] delegates = action.GetInvocationList();
            foreach (Action d in delegates)
            {
                try
                {
                    action();
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception caught");
                }
            }
            Console.ReadKey();
        }

        static void One()
        {
            Console.WriteLine("One");
            throw new Exception("Error in one");
        }

        static void Two()
        {
            Console.WriteLine("Two");
        }
    }
}
//通过一个委托调用多个方法还可能导致一个大问题,多播委托包含一个逐个调用的委托集合
//如果通过委托调用的其中一个方法抛出异常,整个迭代就会停止
//应使用迭代列表来避免这个问题,Delegate类定义了GetInvocationList方法,返回一个Delegate对象数组
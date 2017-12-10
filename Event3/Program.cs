using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event3        //重构Event2的例子,使其符合微软的规范
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化一个出版社
            Publisher publisher = new Publisher();
            Console.Write("请输入要发行的杂志：");
            string name = Console.ReadLine();
            if (name == "海贼王")
            {
                //给这个出海贼王的事件注册感兴趣的订阅者，此例中是小明
                publisher.Publish += new Publisher.PublishEventHander(MrMing.Receive);
                //发布者在这里触发出版海贼王的事件
                publisher.Issue("海贼王");
            }
            else
            {
                //给这个出海贼王的事件注册感兴趣的订阅者，此例中是小明[另一种事件注册方式]
                publisher.Publish += MrZhang.Receive;
                publisher.Issue("环球日报");
            }
            Console.ReadKey();
        }
    }
    //所有订阅者【Subscriber】感兴趣的对象，也就是e,都要继承微软的EventArgs
    //本例中订阅者【也称观察者】MrMing，MrZhang他们感兴趣的e对象，就是杂志【magazine】
    //一、委托声明原型中的Object类型的参数代表了Subject，也就是监视对象，在本例中是 Publisher(出版社)
    //二、EventArgs 对象包含了Observer所感兴趣的数据，在本例中是杂志
    public class PubEventArgs : EventArgs
    {
        public readonly string magazineName;
        public PubEventArgs()
        {

        }
        public PubEventArgs(string magazineName)
        {
            this.magazineName = magazineName;
        }
    }
    //发布者（Publiser)
    public class Publisher
    {
        //声明一个出版的委托
        //这里多了一个参数sender,它所代表的就是Subject，也就是监视对象，本例中就是Publisher
        public delegate void PublishEventHander(object sender, PubEventArgs e);
        //在委托的机制下我们建立以个出版事件
        public event PublishEventHander Publish;
        //声明一个可重写的OnPublish的保护函数
        protected virtual void OnPublish(PubEventArgs e)
        {
            if (Publish != null)
            {
                //Sender = this，也就是Publisher
                this.Publish(this, e);
            }
        }
        //事件必须要在方法里去触发
        public void Issue(string magazineName)
        {
            OnPublish(new PubEventArgs(magazineName));
        }
    }
    //Subscriber 订阅者
    public class MrMing
    {
        //对事件感兴趣的事情
        public static void Receive(object sender, PubEventArgs e)
        {
            Console.WriteLine("嘎嘎，我已经收到最新一期的《" + e.magazineName + "》啦！！");
        }
    }

    public class MrZhang
    {
        //对事件感兴趣的事情
        public static void Receive(object sender, PubEventArgs e)
        {
            Console.WriteLine("幼稚，这么大了，还看《海贼王》，SB小明！");
            Console.WriteLine("这个我定的《" + e.magazineName + "》，哇哈哈！");
        }
    }
}
// .Net Framework的编码规范：
//一、委托类型的名称都应该以EventHandler结束 
//二、委托的原型定义：有一个void返回值，并接受两个输入参数:
//一个Object 类型，一个 EventArgs类型(或继承自EventArgs)
//三、事件的命名为 委托去掉 EventHandler之后剩余的部分
//四、继承自EventArgs的类型应该以EventArgs结尾
//这就是微软编码的规范，当然这不仅仅是规则，而是在这种规则下使程序有更大的灵活性
//那我们就继续重构Event的例子，让它符合微软的规范
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Publisher publisher = new Publisher();
                //给这个出火影忍者的事件注册感兴趣的订阅者，此例中是小明
                //注册事件,事件发生时会通知所有该事件的订阅者,想要被通知就要注册事件
                //事件发生通知订阅者就是调用订阅者的函数,注册事件为了说明发布者应该调用那个函数
                publisher.OnPublish += new Publisher.PublishEventHander(MrMing.Receive);
                //另一种事件注册方式,注册事件的方法可以是实例方法,静态方法,匿名方法,lambda表达式
                publisher.OnPublish += MrZhang.Receive;//如果这句去掉表示小张没有订阅所以小张不会有反应
                publisher.Issue();//发布者出版海贼王时触发OnPublish事件
            }

            {
                //客户买狗,有狗就通知
                Client client1 = new Client();
                Client client2 = new Client();
                Dog d1 = new Dog();//这句放着意味着还没注册就发生,不会有通知
                Dog.HavaDog += Client.WantADog;
                //要把静态方法WantADog改成非静态,这句就可以运行了
                //d1.HavaDog += Client.WantADog;//WantADog时静态方法,可以调用,如果要使用对象来限定调用,
                //不能使用d1.HavaDog,因为d1.HavaDog事件要靠构造函数Dog触发
                //而构造函数不能再调用一次,导致事件无法触发,所以用非静态构造函数触发事件不是合理的设计
                //所以用对象构造函数来触发事件时要把类的构造函数定义为静态,通过类的静态构造函数来触发事件
                //这样才能在外部调用,不然事件就触发不了!
                Dog d2 = new Dog();
            }

            {
                //这里是第二个示例的代码段
                Console.Write("请输入您要取款的金额：");
                string amount = Console.ReadLine();
                Console.WriteLine("交易成功，请取磁卡。");
                //初始化e
                UserEventArgs user = new UserEventArgs("1209032479@qq.com", "18150760350", amount);
                //初始化订阅系统
                SubscribSystem subject = new SubscribSystem(new BankAccount(), user);
            }
            Console.ReadKey();
        }

        private static void Dog_HavaDog()
        {
            throw new NotImplementedException();
        }
    }
    //发布者（Publiser)
    public class Publisher
    {
        //声明一个出版的委托,这个放里面是为了让
        //publisher.OnPublish += new Publisher.PublishEventHander(MrMing.Receive);不会报错
        //也可以声明在外面,这样就用第二种事件注册方式
        public delegate void PublishEventHander();//声明一个委托
        public event PublishEventHander OnPublish;//在委托的机制下我们建立以个出版事件OnPublish
        //     event是一个成员,不好理解
        //OnPublish就可以调用PublishEventHander当中持有的函数
        //OnPublish是一个成员并且会被隐式自动初始化为null
        //事件必须要在方法里去触发，可以理解成为是一种封装的受限制的委托
        //事件只有关注和取消关注两种操作
        //委托中保存着实际订阅者注册的函数,事件触发的时候,调用的也是委托当中持有的函数
        /// <summary>
        /// 过程是首先定义一个委托类型PublishEventHander
        /// 然后在委托的机制下定义事件OnPublish
        /// 详情可以看示例宠物店买狗
        /// </summary>
        //过程是首先定义一个委托类型PublishEventHander
        //
        //订阅者注册委托事件
        public void Issue()
        {
            if (OnPublish != null)//检测事件订阅,如果有人注册了这个事件，也就是这个事件不是空
            {
                Console.WriteLine("最新一期的《海贼王》今天出版哦！");
                OnPublish();//事件触发
            }
        }
    }
    //Subscriber 订阅者小明
    public class MrMing
    {
        //对事件感兴趣的事情，这里指对出版社的书感兴趣
        public static void Receive()
        {
            Console.WriteLine("最新一期的《海贼王》出版啦！我知道了!");
        }
    }
    //Subscriber 订阅者小张
    public class MrZhang
    {
        //对事件感兴趣的事情
        public static void Receive()
        {
            Console.WriteLine("幼稚，这么大了，还看《海贼王》，SB小明！");
        }
    }

    public class Client
    {
        public static void WantADog()
        {
            Console.WriteLine("我知道有狗了!");
        }
    }
    public class Dog
    {
        public delegate void BuyDog();
        public static event BuyDog HavaDog;//声明为静态事件是为了没有狗时也可以调用事件
        public Dog()
        {
            Console.WriteLine("宠物店有新的狗了!");
            //if (HavaDog!=null)
            //{
            //    HavaDog();//复杂版委托调用
            //}
            HavaDog?.Invoke();//简化版委托调用
        }
    }

    //---本例场景为当用户从银行账号里取出钱后，马上通知电子邮件和发手机短信
    //本例中的订阅者，也就是观察者是电子邮件与手机
    //发布者，也就是被监视对象是银行账号
    //Obverser电子邮件,手机关心的对象e,分别是邮件地址、手机号码、取款金额
    public class UserEventArgs : EventArgs
    {
        public readonly string emailAddress;
        public readonly string mobilePhone;
        public readonly string amount;
        public UserEventArgs(string emailAddress, string mobilePhone, string amount)
        {
            this.emailAddress = emailAddress;
            this.mobilePhone = mobilePhone;
            this.amount = amount;
        }
    }
    //发布者，也就是被监视的对象-银行账号
    class BankAccount
    {
        //声明一个处理银行交易的委托
        public delegate void ProcessTranEventHandler(object sender, UserEventArgs e);
        //声明一个事件
        public event ProcessTranEventHandler ProcessTran;
        protected virtual void OnProcessTran(UserEventArgs e)
        {
            ProcessTran?.Invoke(this, e);//简化版委托调用
            //if (ProcessTran != null)
            //{
            //    ProcessTran(this, e);//复杂版委托调用
            //}
        }
        public void Prcess(UserEventArgs e)
        {
            OnProcessTran(e);
        }
    }
    //观察者Email
    class Email
    {
        public static void SendEmail(object sender, UserEventArgs e)
        {
            Console.WriteLine("向用户邮箱" + e.emailAddress + "发送邮件:您在" + System.DateTime.Now.ToString() + "取款金额为" + e.amount);
        }
    }
    //观察者手机
    class Mobile
    {
        public static void SendNotification(object sender, UserEventArgs e)
        {
            Console.WriteLine("向用户手机" + e.mobilePhone + "发送短信:您在" + System.DateTime.Now.ToString() + "取款金额为" + e.amount);
        }
    }
    //订阅系统，实现银行系统订阅几个Observer，实现与客户端的松耦合
    class SubscribSystem
    {
        public SubscribSystem()
        {

        }
        public SubscribSystem(BankAccount bankAccount, UserEventArgs e)
        {
            //现在我们在银行账户订阅2个，分别是电子邮件和手机短信
            bankAccount.ProcessTran += new BankAccount.ProcessTranEventHandler(Email.SendEmail);
            bankAccount.ProcessTran += new BankAccount.ProcessTranEventHandler(Mobile.SendNotification);
            bankAccount.Prcess(e);
        }
    }
}
//这个设计模式是观察者（Observer）模式在C#的event中委托充当了抽象的Observer接口而提供事件的对象充当了目标对象。委托是比抽象Observer接口更为松耦合的设计
//在讲委托事件之前，我想问大家一个非常简单的问题，也许在我们日常的编程中基本上每天都会遇到，但是却往往不去了解的地方，请以下代码：
//protected void Page_Load(object sender, EventArgs e)
//{
//}
//protected void btnSearch_Click(object sender, ImageClickEventArgs e)
//{
//}
//protected void grdBill_RowDataBound(object sender, GridViewRowEventArgs e)
//{

//}
//protected void grdBill_RowDeleting(object sender, GridViewDeleteEventArgs e)
//{

//}
//看完之后大家是不是很熟悉，是不是我们每天都遇到过的，但是大家有没有想过所有方法中的两个参数（sender,e），到底是什么意思
//有的人可能会说，这些都是VS编译环境自动生成的，不就是个窗体加载事件、点击按钮事件嘛，第二种人可能马上会去百度，谷歌一下
//第一個,sender,也就是引起事件的那個對象
//第二個, e包含了事件的信息
//第一个表示事件的对象，第二个表示事件的信息，貌似好像云里雾里的，接着查：
//摘自网络的师生的一段对话：
//大李推了推眼镜，反问我道：“你应该对Windows编程中的事件驱动程序设计很熟悉吧？”
//“事件驱动就是说应用程序的执行流程是由外界发生的事件所确定的,也就是接受到任务才工作的模式。
//事件就是一个信号，它告知应用程序有重要情况要发生。实际上的执行情况是
//各个应用程序把负责不同工作的对象在其运行期间送入Windows操作系统，让这些对象等待Windows产生的事
//件，然后加以处理。”
//“VB程序员一般也只需要象你这样理解就行了。”大李的话真让我触动，“应该说是Windows先产生消息，应用程序中的窗
//口程序window procedure能接收来自windows的消息，并将其转化为事件，这个我们以后再说。现在来看看事件驱动程序的
//组成，主要是有事件、对象和事件处理程序三个要素。对象就是完成任务的主体，比如你说的Button1；事件么，就是对象
//要执行的任务，比如单击，就是click事件；那么事件处理程序就是Button1_Click这段程序了。”
//“这个我知道呀！我只是想问一下Sender……”我疑惑地回应道。
//大李哥摇摇手，打断了我的话。“如果你真正清楚事件驱动的话，就明白了。你看一下，Sender是什么类型的变量？”
//“object呀！”我无奈地问道着，“但是，……”我隐约感觉到了什么。
//大李微笑着说，“sender as object，就一语道破它的来源与用途。object是支持.NET 框架类层次结构中的所有类
//并为派生类提供低级别服务。这是.NET 框架中所有类的最终超类；它是类型层次结构的根。
//一般来说，sender在形参中表示引发事件的源头，就是我刚才所说的三要素中的‘对象’。
//如果在控件引发的事件中写代码的话，一般都不需要再重新指派，因为它已经默认为是该控件了。
//当自己写代码来调用某事件程序时，就要注明sender是何物了。”
//“也就是说，sender是提供给在事件处理程序代码内部或外部进行调用的吗？”我仍有点不明白。
//“可以这样说，你难道看不出VB.NET提供给我们的是更全面、更直接的控制吗？
//再说e，表示的是事件数据，就是一个事件激发所需要的状态信息。
//在事件引发时不向事件处理程序传递状态信息的事件会将e设为Eventargs。
//如果事件处理程序需要状态信息，则应用程序必须从此类派生一个类来保存数据。
//比如Mousedown事件，系统需要判断mouse的位置、判断是左中右哪个键点击了、判断点击了几下等
//因此该e就必需是System.Windows.Forms.MouseEventArgs类的实例。”
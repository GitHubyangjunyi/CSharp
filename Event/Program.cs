using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        // 定义客车超速时的事件处理程序
        private static void Speed_Changed(object sender, EventArgs e)
        {
            int sp = ((Bus)sender).Speed;
            if (sp < Bus.Speed_MAX)    // SMAX为静态字段
                Console.WriteLine("客车时速{0}在正常范围内！", sp);
            else
                Console.WriteLine("客车时速最大值为{0},你已超速，危险!", Bus.Speed_MAX);
        }
        static void Main(string[] args)
        {
            //测试一，无参构造函数调用
            Console.WriteLine("\n测试一:无参构造函数调用--------------------");
            Bus bus = new Bus();  //声明并实例化客车对象bus
            bus.Showinfo();   //调用bus的Showinfo方法输出客车信息
                              //测试二，有参构造函数调用
            Console.WriteLine("\n测试二:有参构造函数调用---------------------");
            Bus bus2 = new Bus(20, "渝AA8888");
            bus2.Showinfo();
            //测试三，虚函数和多态性测试
            Console.WriteLine("\n测试三:虚函数和多态性测试-------------------");
            Transport tp1 = new Bus();
            Transport tp2 = new CityBus();
            Transport tp3 = new Taxi();
            tp1.Speak();
            tp2.Speak();
            tp3.Speak();
            //测试四，接口定义和使用
            Console.WriteLine("\n测试四:接口定义和使用----------------------");
            IBus ip = new Bus();
            ip.Plate = "渝AA8888";  //通过接口的Plate属性设置客车的车牌号
            ip.Showinfo();      //通过接口的Showinfo方法输出信息
                                //测试五，事件测试
            Console.WriteLine("\n测试五:事件触发----------------------------");
            // 将事件处理程序添加到事件的调用列表中(即事件绑定)
            bus.OnChanged += new Bus.ChangedEventHandler(Speed_Changed);
            //设置属性值，触发相应的事件
            bus.Speed = 120;
            Console.Read();
        }
    }
}
//定义交通工具的抽象类
public abstract class Transport
{   //定义字段保存交通工具类型，1：船；2：汽车；3：飞机
    public int type;
    //构造函数
    public Transport()
    {
        //Console.WriteLine("交通工具类型 默认为汽车");
        type = 2;
    }
    public Transport(int ty)
    {
        type = ty;
        switch (ty)
        {
            case 1:
                Console.WriteLine("交通工具类型为：船");
                break;
            case 2:
                Console.WriteLine("交通工具类型为：汽车");
                break;
            case 3:
                Console.WriteLine("交通工具类型为：飞机");
                break;
        }
    }
    //声明发声的抽象方法
    public abstract void Speak();
}
//定义交通工具接口，通过此接口可以向外提供访问
interface IBus
{
    int Speed { get; set; }
    string Plate { get; set; }
    void Showinfo();
}
//定义类名为Bus  (客车)
public class Bus : Transport, IBus  //继承于抽象类和接口
{
    //以下为成员字段----------------------------------------
    private int passengers;   //私有成员,准载乘客数
    public string plate;      //公有成员,车牌号
    private int speed;       //私有成员,行驶速度  
    public static float Speed_MAX = 100; //静态公有字段，最大时速
                                         //以下为成员事件----------------------------------------
                                         // 定义事件的委托
    public delegate void ChangedEventHandler(object sender, EventArgs e);
    // 定义一个事件
    public event ChangedEventHandler OnChanged;
    //以下为成员属性----------------------------------------
    //实现IBus中的Speed属性，访问speed字段
    public int Speed
    {
        get { return speed; }
        set
        {
            speed = value;
            // 设置时速时触发OnChange事件
            if (this.OnChanged != null)     //this指本类的实例
                this.OnChanged(this, new EventArgs());
        }
    }
    //以下实现接口中的Plate属性
    public string Plate
    {
        get { return plate; }
        set { plate = value; }
    }
    public int Passengers     //声明属性乘客数
    {
        get { return passengers; }
        set { passengers = value; }
    }
    //客车的当前时速属性
    //以下为成员方法----------------------------------------
    //声明公有含参数的构造方法，参数we、p、wh、sp分别传递车重、载客量、车轮、车牌号

    public Bus(int p, string pl) : base(2)
    {   // p、sp、pl代表载客量、车速、车牌号
        Passengers = p;
        plate = pl;
    }
    //声明一个不含参数的构造方法
    public Bus() : base()
    {
        passengers = 20;
        plate = "000000";

    }
    //声明公有方法，输出客车的相关信息
    public void Showinfo()
    {
        Console.WriteLine("我是客车");
        Console.WriteLine("我的车牌号是:" + plate);
        Console.WriteLine("我的载客量是:" + Passengers);
    }
    //重载父类的抽象方法——发声方法
    public override void Speak()
    {
        Console.WriteLine("我是客车，我的喇叭声是嘟嘟!");
    }

}
//定义出租车类，继承于客车类
public class Taxi : Bus
{
    private const float BaseCost = 5.0f;  //起步价5元
    private float price;    //每公里价格 
    public float Price     //每公里价格
    {
        get { return price; }
        set { price = value; }
    }
    //声明无参数的构造方法
    public Taxi() : base(4, "TX0001")
    {
        price = 1.2F;
    }
    //声明含参数的构造方法   
    public Taxi(int p, string pl, float pri) : base(p, pl)
    {   //参数p、pl、pri分别传递载客量、车牌号、每公里价格
        price = pri;
    }
    public float Money(float dis)   //根据路程计算应付金额的方法
    {
        return dis <= 3 ? BaseCost : BaseCost + (dis - 3) * Price;
    }
    //以下重写父类方法，输出出租车的相关信息
    public new void Showinfo()
    {
        Console.WriteLine("我是出租车,我的车牌号是:" + Speed);
        Console.WriteLine("起步价是{0}元,超过3公里时每公里{1}元.", BaseCost, Price);
    }
    public override void Speak()
    {
        Console.WriteLine("我是出租车，我的喇叭声是嘀嘀!");
    }
}
//定义一个继承于客车类的中巴车类，并重写虚方法
class CityBus : Bus  //继承于客车的公交车类
{
    public CityBus() : base()
    {
        Passengers = 20;
        plate = "000000";
    }
    public override void Speak()
    {
        Console.WriteLine("我是公交车，我的喇叭声是哒哒!");
    }
}
//事件也称为消息,对象之间相互联动的途径,表示对象之间发出的行为请求,让不同的对象一起构成了有机的运行系统
//事件在其他对象请求某个对象执行某种行为时被触发
using DelegateEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent//C#高级编程中关于委托的示例,事件
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CarDealer();
            var Michael = new Consumer("Michael");
            dealer.NewCarInfo += Michael.NewCarIsHere;//订阅事件
            dealer.NewCar("Ferrari");
            var Sebation=new Consumer("Sebation");
            dealer.NewCarInfo += Sebation.NewCarIsHere;
            dealer.NewCar("Mercedes");
            dealer.NewCarInfo -= Michael.NewCarIsHere;//取消订阅
            dealer.NewCar("Red Bull Racing");
            Console.ReadKey();
        }
    }

    //事件发布程序
    public class CarInfoEventArgs : EventArgs
    {
        public string Car { get; private set; }

        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }

    }
    
    public class CarDealer//CarDealer类基于事件提供一个订阅
    {
        public event EventHandler<CarInfoEventArgs> NewCarInfo;//定义了类型为EventHandler<CarInfoEventArgs>的NewCarInfo事件
        //然后再NewCar()方法中,通过调用RaiseNewCarInfo方法触发NewCarInfo,这个方法的实现检查委托是否为空,不为空引发事件

        protected virtual void RaiseNewCarInfo(string car)//在这个方法中触发事件
        {
            NewCarInfo?.Invoke(this, new CarInfoEventArgs(car));//简化版委托调用
            //EventHandler<CarInfoEventArgs> newCarInfo = NewCarInfo;
            //if (newCarInfo != null)
            //{
            //    newCarInfo(this, new CarInfoEventArgs(car));
            //}
        }

        public void NewCar(string car)
        {
            Console.WriteLine("CarDealer,new car {0}", car);
            RaiseNewCarInfo(car);
        }
    }
    
    public class Consumer//Consumer类用作事件侦听器,这个类订阅了CarDealer类的事件,并定义了NewCarIsHere方法,该方法满足EventHandler<CarInfoEventArgs>的要求,其参数类型是object和CarInfoEventArgs
    {
        private string name;

        public Consumer(string name)
        {
            this.name = name;
        }

        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine("{0}:car {1} is new", name, e.Car);
        }
    }
}
//事件基于委托,为委托提供了一种发布/订阅机制,Button类提供了Click事件,这类事件就是委托
//出发Click事件时调用的处理程序方法需要定义,其参数有委托类型决定
//在这个示例中,事件用于连接CarDealer类和Consumer类,CarDealer类提供了一个新车到达时触发的事件
//Consumer类订阅该事件,以获得新车到达的通知
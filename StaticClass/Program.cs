﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.ShowName();//静态成员不依赖于对象去实现而是依赖于类
            Console.ReadKey();
        }
    }
    public static class StaticClass
    {
        private static string name = "jingkyx";
        public static void ShowName()
        {
            Console.WriteLine("我的名字是" + name);
        }
    }
}
//当类中的所有成员都是静态成员时(只包含静态成员),且不包含示例构造函数,就可以把这个类声明为静态类.在class关键字前面加上static
//静态类的成员并不是默认为静态的,必须用static显示声明为静态成员
//静态类是密封的,不能被继承,不能使用abstract或sealed修饰
//静态类相当于一个sealed abstract类,主要的一个优点是写在栈中,安全高速稳定,而且在执行的时候,十分优先
//类可以声明为static的,以指示它仅包含静态成员,不能使用new关键字创建静态类的实例,静态类在加载包含该类的程序或命名空间时由.NET Framework公共语言运行库(CLR; 特指：C#语言) 自动加载
//它们仅包含静态成员
//它们不能被实例化
//它们是密封的
//它们不能包含实例构造函数
//因此创建静态类与创建仅包含静态成员和私有构造函数的类大致一样,私有构造函数阻止类被实例化
//使用静态类的优点在于,编译器能够执行检查以确保不致偶然地添加实例成员,编译器将保证不会创建此类的实例
//静态类是密封的,因此不可被继承,静态类不能包含构造函数,但仍可声明静态构造函数以分配初始值或设置某个静态状态
//注意事项
//静态类不能有实例构造器
//静态类不能有任何实例成员,静态类不能使用abstract或sealed修饰符,静态类默认继承自System.Object根类,不能显式指定任何其他基类
//静态类不能指定任何接口实现
//静态类的成员不能有protected或protected internal访问保护修饰符
//为了说清楚你这个问题，我得打很多字
//当你设计一个类并且在设计的时候就确定不希望将来有人（或者你自己）因为凌乱的继承关系,使这个类的最初动机变得扑朔迷离的时候,可以将这个类sealed（为什么要不希望自己继承这个类后做改动？因为你的脑袋并不是电脑,你的记性并不是那么好,最初的设计初衷,在以后系统越来越庞大的时候,你可能自己都忘了自己当初设计的这个类可能考虑到的某些很细微的因素,这个因素要求你将来不要改变这个类的成员或者任何属性）,当你有个基类A然后有个类B继承A然后类C又继承B类D又继承类C的时候你可能会发生凌乱,这个时候,有些类在设计之初你就可以将它sealed,以确保将来在某一个时刻脑袋短路的情况想把这个类继承出一个子类来改写的时候,编译器就会报错提示你,“唤起”你的记忆
//比如.net中,你可能没注意到过,struct也是sealed的,你不能继承一个struct,另外.net framework中还有一些成员都是静态类型的类,比如Pen和Brushes也是sealed的,因为画笔和画刷在设计之初都已经定义好了它都有哪些颜色,并且不希望将来改变画笔和画笔的这些属性,所以直接给它sealed掉
//另外，如果你的程序中有用到反射的话，CLR对用了sealed关键字的类和属性会比普通的类有一点性能上的提升。因为反射需要找回某个类的属性，没有继承关系的类，它的“关系网”不复杂，CLR能够很轻易地定位它的“位置”。
//sealed还可以用于限制类成员方法等。
//比如你有一个类A包含了一个vitual虚方法FOO1，另外一个类B继承了A，并且还有另外一个类C继承了类B，在这种情况下，类C可以跳过类B而直接从类A override 方法 FOO1，而不管类B是否override了方法FOO1，这个时候很容易发生凌乱。你的设计结构很有可能拎不清了。
//什么时候用sealed关键字？事实上，所有的类在设计之初，你都可以设计为sealed，直到你将来在设计别的类的时候，确定需要从这个类有继承关系，因为任何类sealed以后，你还可以将它unsealed（直接以掉sealed关键字）
//另外，在一些类含有一些安全方面考虑的成员或者属性，不希望被别的类继承或者改变的时候，可以设计为sealed
//总而言之，言而总之，sealed关键字有一部分用途比如CLR反射时候性能方面的优化，但是最主要的目的应该是为了帮助开发人员尽量避免在设计和编程的过程人为的犯错，让你在连续加班48个小时后保持清晰的思路记得你当初设计的某个不希望被继承改动的类的目的而不犯错，要求是不是太高了！所以，微软的天才们设计了这个关键字，帮助了大家一把，让这个需要注意和提醒的事情，交给了CLR和编译器
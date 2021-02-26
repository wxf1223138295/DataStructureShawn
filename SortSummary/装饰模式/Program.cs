using System;

namespace 装饰模式
{
    /// <summary>
    /// 动态地给一个对象增加一些额外的职责。就增加功能而言，Decorator模式比生成子类更为灵活。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AppleMobilePhone appleMobilePhone=new AppleMobilePhone();
            
            MobilePhoneShell shell=new MobilePhoneShell(appleMobilePhone);
            shell.Print();

            Console.WriteLine("Hello World!");
        }
    }

    public abstract class MobilePhone
    {
        public abstract void Print();
    }

    public class AppleMobilePhone : MobilePhone
    {
        public override void Print()
        {
            Console.WriteLine("我是一部苹果手机！");
        }
    }

    public class Decorator : MobilePhone
    {
        private MobilePhone _mobile;

        public Decorator(MobilePhone mobile)
        {
            _mobile = mobile;
        }
        public override void Print()
        {
            _mobile.Print();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MobilePhoneShell: Decorator
    {
        public MobilePhoneShell(MobilePhone mobile) : base(mobile)
        {
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("带了手机保护壳！");
        }
    }


    public class MobilePhoneStickers : Decorator
    {
        public MobilePhoneStickers(MobilePhone mobile) : base(mobile)
        {
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("贴了手机贴膜！");
        }

    }
}

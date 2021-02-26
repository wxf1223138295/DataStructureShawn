using System;
using System.Threading.Channels;

namespace 抽象工厂模式
{
    /// <summary>
    /// 抽象工厂
    /// 抽象产品
    /// 具体工厂
    /// 具体产品
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory factory=new BMWFactory();
            var bwmcar=factory.CreateCar();
            bwmcar.Run();

            FactoryFactory factorys=new BWNFactory();
            var  car=factorys.CreateCar();

            car.Run();
            car.SpecialFunctory();

            Console.WriteLine("Hello World!");
        }
    }



    #region 抽象类的实现

    public abstract class FactoryFactory
    {
        public abstract CarFactory CreateCar();
    }
    public abstract class CarFactory
    {
        public virtual void Run()
        {
            Console.WriteLine($"车跑起来了");
        }

        public abstract void SpecialFunctory();
    }
    public class BWNFactory : FactoryFactory
    {
        public override CarFactory CreateCar()
        {
            return new BWMCAR();
        }
    }

    public class Audi1Factory : FactoryFactory
    {
        public override CarFactory CreateCar()
        {
            return new AudiCAR();
        }
    }



    public class BWMCAR : CarFactory
    {
        public override void SpecialFunctory()
        {
            Console.WriteLine("宝马操作性好");
        }
    }
    public class AudiCAR : CarFactory
    {
        public override void SpecialFunctory()
        {
            Console.WriteLine("我灯牛逼");
        }
    }

    #endregion




    #region 接口实现

    public interface ICarFactory
    {
        ICar CreateCar();
    }

    public interface ICar
    {
        void Run();
    }

    public class BMWFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new BWM();
        }
    }
    public class AudiFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Audi();
        }
    }
    public class BWM : ICar
    {
        public void Run()
        {
            Console.WriteLine("宝马跑起来了");
        }
    }
    public class Audi : ICar
    {
        public void Run()
        {
            Console.WriteLine("奥迪跑起来了");
        }
    }

    #endregion


}

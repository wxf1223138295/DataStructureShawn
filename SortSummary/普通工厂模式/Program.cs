using System;

namespace 普通工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    /// 简单工厂
    /// 抽象产品
    /// 具体产品
    /// 工厂类
    /// </summary>
    public class SomeFactory
    {
        public CarAbs CreateCar(string type)
        {
            switch (type)
            {
                case "bmw":
                    return new BMW();
                    break;
                case "audi":
                    return new Audi();
                    break;
                default:
                    throw new ArgumentException("不存在此类型的对象");
            }
        }
    }
    /// <summary>
    /// 抽象产品类
    /// </summary>
    public abstract class CarAbs
    {
        public virtual void Run()
        {
            Console.WriteLine("RUN");
        }
    }

    public class BMW: CarAbs
    {

    }

    public class Audi : CarAbs
    {

    }
}

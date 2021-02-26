using System;
using System.Collections.Generic;

namespace 生成器模式
{
    /// <summary>
    /// 造车
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Director d=new Director();
            Contructor1 c=new Contructor1();
            d.CreateCar(c);
            Car car = c.GetCar();
            car.Show();
            Console.WriteLine("Hello World!");
        }
    }

    public class Director
    {
        public void CreateCar(Builder builder)
        {
            builder.CreateJiaZi();
            builder.AddFaDongji();
            builder.AddLunZi();
           
        }
    }


    public class Contructor1: Builder
    {
        Car c=new Car();
        public override void CreateJiaZi()
        {
            c.lists.Add("CreateJiaZi");
        }

        public override void AddLunZi()
        {
            c.lists.Add("AddLunZi");
        }

        public override void AddFaDongji()
        {
            c.lists.Add("AddFaDongji");
        }

        public override Car GetCar()
        {
            return c;
        }
    }
    public abstract class Builder
    {
        public abstract void CreateJiaZi();
        public abstract void AddLunZi();
        public abstract void AddFaDongji();

        public abstract Car GetCar();
    }

    public class Car
    {
        public List<string> lists=new List<string>();
        public void AddComponent(string component)
        {
            lists.Add(component);
        }

        public void Show()
        {
            lists.ForEach(p =>
            {
                Console.WriteLine(p);
            });
        }
    }
}

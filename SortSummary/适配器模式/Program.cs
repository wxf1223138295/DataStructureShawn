using System;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    public interface ITarget
    {
        void Request();
    }

    public class Adaptee
    {
        public void AdapteeFunction()
        {
            Console.WriteLine("被适配的");
        }
    }
    public class Adapter : Adaptee,ITarget
    {
        //调用被适配的  就算满足了 被适配的条件 
        public void Request()
        {
            //这样
            base.AdapteeFunction();

            Console.WriteLine("为了适配，再去做其他功能");
        }
    }
}

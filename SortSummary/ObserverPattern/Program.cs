using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Publisher p=new Publisher();

            p.Register(new Observer1());
            p.Register(new Observer2());

            p.Publishing();

            Console.WriteLine("Hello World!");
        }
    }

    public class Observer1:IObserver
    {
        public void ReciverMsg()
        {
            Console.WriteLine($"{nameof(Observer1)}收到消息");
        }
    }
    public class Observer2 : IObserver
    {
        public void ReciverMsg()
        {
            Console.WriteLine($"{nameof(Observer2)}收到消息");
        }
    }
    public abstract class BasePublish
    {
        public Dictionary<IObserver, IObserver> observers=new Dictionary<IObserver, IObserver>();

        public void Register(IObserver observer)
        {
            observers.Add(observer, observer);
        }

        public void Undo(IObserver observer)
        {
            if (observers.ContainsKey(observer))
            {
                observers.Remove(observer);
            }
            
        }

        public void Publishing()
        {
            observers.ToList().ForEach(p =>
            {
                p.Value.ReciverMsg();
            });
        }
    }

    public interface IObserver
    {
        void ReciverMsg();
    }

    public class Publisher : BasePublish
    {

    }
}

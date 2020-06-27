using System;

namespace ExchangeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //不声明临时变量
            int x = 1;
            int y = 2;
            Console.WriteLine("x={0},y={1}", x, y);
            x = x + y;

            y = x - y;
            x = x - y;
            Console.WriteLine("x={0},y={1}", x, y);
          

            //异或运算

            int a = 3;
            int b = 4;
            Console.WriteLine("a={0},b={1}", a,b);
            a = a ^ b;

            b = a ^ b;

            a = a ^ b;

            Console.WriteLine("a={0},b={1}", a, b);

            Console.ReadKey();
        }
    }
}

using System;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明数据进行相应的测试
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };

            for (int i = 0; i < myArray.Length-1; i++)
            {
                for (int j = 0; j < myArray.Length - 1-i; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        var temp=myArray[j];
                        myArray[j]=myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();
        }
    }
}

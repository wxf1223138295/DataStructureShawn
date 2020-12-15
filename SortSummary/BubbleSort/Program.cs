using System;
using System.Collections.Generic;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            //声明数据进行相应的测试
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };
            //int temp = 0;
            for (int i = 0; i < myArray.Length-1; i++)
            {
                for (int j = 0; j < myArray.Length-1-i; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {        // 相邻元素两两对比
                        var temp = myArray[j + 1];        // 元素交换
                        myArray[j + 1] = myArray[j];
                        myArray[j] = temp;
                    }
                    //if (myArray[j] > myArray[j + 1])
                    //{
                    //    temp = myArray[j];
                    //    myArray[j] = myArray[j + 1];
                    //    myArray[j + 1] = temp;
                    //}
                }
            }

            //输出排完之后的数组
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }

            Console.ReadKey();
        }
    }
}

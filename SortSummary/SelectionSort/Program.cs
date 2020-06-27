using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明数据进行相应的测试
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };
            int minIndex, temp;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[minIndex])
                    {
                        // 寻找最小的数
                        minIndex = j; // 将最小数的索引保存
                    }
                }

                temp = myArray[i];
                myArray[i] = myArray[minIndex];
                myArray[minIndex] = temp;
            }
            //输出排完之后的数组
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }
        }
    }
}

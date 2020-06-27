using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明数据进行相应的测试
            int[] myArray = new int[] {45, 36, 18, 53, 72, 30, 48, 93, 15, 36};
            int preIndex, current;
            for (var i = 1; i < myArray.Length; i++)
            {
                //从第二个数开始，取出数 和前一个比较
                preIndex = i - 1;
                current = myArray[i];

                while (preIndex >= 0 && myArray[preIndex] > current)
                {
                    myArray[preIndex + 1] = myArray[preIndex];
                    preIndex--;
                }
                myArray[preIndex + 1] = current;
            }

            //输出排完之后的数组
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }
        }
    }
}

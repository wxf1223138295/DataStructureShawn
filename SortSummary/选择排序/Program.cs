using System;

namespace 选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            a = a++;
            a = ++a;
            //声明数据进行相应的测试
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int j = i+1;
                int minIndex = i;
                while (j<= myArray.Length - 1)
                {
                    if (myArray[j]<myArray[minIndex])
                    {
                        minIndex = j;
                    }
                    j++;
                }
                var temp = myArray[i];
                myArray[i] = myArray[minIndex];
                myArray[minIndex] = temp;
               
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

using System;
using System.Runtime;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace 插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明数据进行相应的测试
            int[] myArray = new int[] { 4, 3, 7, 2, 1, 9, 6, 0, 5, 8 };


            for (int i = 1; i < myArray.Length; i++)
            {
                var preindex = i - 1;
                var currentvalue = myArray[i];

                while (preindex >= 0 && myArray[preindex] > currentvalue)
                {
                    myArray[preindex + 1] = myArray[preindex];
                    preindex--;
                }
                myArray[preindex + 1] = currentvalue;

            }

           
            

            //输出排完之后的数组
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }
            Console.ReadKey();


            ////升序
            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    var preindex = i - 1;
            //    var current = myArray[i];
            //    while (preindex >= 0 && myArray[preindex] > current)
            //    {
            //        //45, 45, 18, 53, 72, 30, 48, 93, 15, 36 
            //        myArray[preindex + 1] = myArray[preindex];

            //        preindex = preindex - 1;

            //    }
            //    //36, 45, 18, 53, 72, 30, 48, 93, 15, 36 
            //    myArray[preindex + 1] = current;
            //}

            ////降序
            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    var preindex = i - 1;
            //    var current = myArray[i];
            //    while (preindex >= 0 && myArray[preindex] < current)
            //    {
            //        //45, 45, 18, 53, 72, 30, 48, 93, 15, 36 
            //        myArray[preindex + 1] = myArray[preindex];

            //        preindex = preindex - 1;

            //    }
            //    //36, 45, 18, 53, 72, 30, 48, 93, 15, 36 
            //    myArray[preindex + 1] = current;
            //}
        }
    }
}

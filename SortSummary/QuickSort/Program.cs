using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明数据进行相应的测试
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };

            int lowIndex = 0;                           //数组的起始位置（从0开始）
            int highIndex = myArray.Length - 1;         //数组的终止位置


            //快速排序
            QuickSortFunction(myArray, lowIndex, highIndex);

            //输出排完之后的数组
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }

            Console.ReadKey();
        }

        public static void QuickSortFunction(int[] list,int left,int right) 
        {
            if(left>=right) return;
            var pivotindex = QuickSortPivot(list, left, right);

            QuickSortFunction(list,left, pivotindex - 1);
            QuickSortFunction(list, pivotindex + 1,right );
        }

        public static int QuickSortPivot(int[] list, int left, int right)
        {
            int Pivot = list[left];

            int i = left;
            int j = right;
            //5  8   1   2  10  9  基准是5 
            while (i<j)
            {
                //从右往左  找到比基准小的第一个
                while (list[j] >= Pivot && i < j) j--;
                //2  8  1  2  10 9
                list[i] = list[j];

                //从左往右 找到大于基准的
                while (list[i] <= Pivot && i < j) i++;
                //2   2  1   8  10   9
                list[j] = list[i];

            }


            //2 5 1 8 10 9
            list[i] = Pivot;

            //第一次  i=1了
            return i;
        }
    }
}

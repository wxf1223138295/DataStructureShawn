using System;

namespace 快速排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明数据进行相应的测试
            int[] myArray = new int[] { 4, 3, 7, 2, 1, 9, 6, 0, 5, 8 };
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

        public static void QuickSortFunction(int[] list, int left, int right)
        {
            if (left < right)
            {
                //----前序遍历

                //找基准值
                var basevalueindex = QuickBase(list, left, right);

                QuickSortFunction(list, left, basevalueindex - 1);
                QuickSortFunction(list, basevalueindex + 1, right);
            }
            
        }

        public static int QuickBase(int[] list, int left, int right)
        {
            int basevalueindex = list[left];
            int i = left;
            int j = right;
            while (i<j)
            {
                //从后往前 找比基准值小的
                while (list[j]>=basevalueindex&& i < j)
                {
                    j--;
                }

                list[i] = list[j];

                //从前往后 找比基准值大的 
                while (list[i]<= basevalueindex&& i < j)
                {
                    i++;
                }

                list[j] = list[i];
            }

            list[i] = basevalueindex;

            return i;
        }
    }
}

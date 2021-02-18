using System;

namespace 归并排序
{
    class Program
    {
        static void Main(string[] args)
        {

            //声明数据进行相应的测试
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };

            MergeSortFunction(myArray, 0, myArray.Length - 1);

            //输出排完之后的数组
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }


        }

        private static void MergeSortFunction(int[] arry,int startindex,int endindex)
        {
            //找到中间索引位置

            //1。确定终止条件
            if (startindex < endindex)
            {
                int mid = (startindex + endindex) / 2;

                MergeSortFunction(arry,startindex,mid);
                MergeSortFunction(arry, mid+1, endindex);
                MergeSort(arry, startindex,mid,endindex);
            }
        }

        private static void MergeSort(int[] arry, int l,int m,int e)
        {
            int[] temp=new int[e-l+1];

            int i = l;
            int j = m + 1;
            int t = 0;
            while (i<=m&&j<=e)
            {
                if (arry[i] <= arry[j])
                {
                    temp[t++] = arry[i++];
                }
                else
                {
                    temp[t++] = arry[j++];
                }
            }

            //没加入临时的
            while (i<=m)
            {
                temp[t++] = arry[i++];
            }

            while (j<=e)
            {
                temp[t++] = arry[j++];
            }

            t = 0;

            //将数组copy到原数组
            while (l<=e)
            {
                arry[l++] = temp[t++];
            }
        }
    }
}

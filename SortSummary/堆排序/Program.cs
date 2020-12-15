using System;

namespace 堆排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明数据进行相应的测试
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };
            
            //创建树
            CreateTree(myArray);
            
        }

        public static void CreateTree(int[] arry)
        {
            //完全二叉树 最下面一排  个数等于上面之和
            //所以中间的那个点是完全二叉树的最后一个根节点

            for (int i = arry.Length / 2 - 1; i > 0; i--)
            {
                SelectMax(arry,i,arry.Length);
            }
        }

        public static void SelectMax(int[] array,int rootindex,int heapSize)
        {
            int left = 2 * rootindex + 1;
            int right = 2 * rootindex + 2;
            int large = rootindex;
            if (left < heapSize && array[left] > array[large])  //与左子节点进行比较
            {
                large = left;
            }
            if (right < heapSize && array[right] > array[large])    //与右子节点进行比较
            {
                large = right;
            }

            if (rootindex != large)//有变化
            {
                //当前根节点和large这个节点换位置
                //交换数值
                
            }
        }
    }
}
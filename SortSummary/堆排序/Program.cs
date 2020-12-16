using System;

namespace 堆排序
{
    class Program
    {
        /// <summary>
        /// 1.创建完全二叉树（区别满二叉树）
        /// 2.从数字中间往前遍历  数组长度/2 -1
        /// 3.左右节点 分别为 当前 i索引   左节点  2*i+1   右节点 2*i+2
        /// 4.比较左右 和根节点大写  把最大的设置在根节点  
        /// 5.设置临时值 保存 最大的索引
        /// 6.如果临时值和开始进来的索引不等，说明最大值有变化  交换值  把最大的设置在根节点
        /// 7.交换值之后在递归  直到符合条件
        /// 8.再次从头循环数组 把0索引的值和i的交换  再调用selectmax 一直是0 长度减减
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //声明数据进行相应的测试
            int[] myArray = new int[] { 45, 36, 18, 53, 72, 30, 48, 93, 15, 36 };
            //创建树
            CreateTree(myArray);

            for (int i = myArray.Length-1; i>0; i--)
            {
                Swap(ref myArray,0,i);
      
                SelectMax(myArray,0,i);
            }

            //输出排完之后的数组
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i].ToString());
            }
            Console.ReadKey();
        }

        public static void CreateTree(int[] arry)
        {
            //完全二叉树 最下面一排  个数等于上面之和
            //所以中间的那个点是完全二叉树的最后一个根节点

            for (int i = (arry.Length / 2)-1 ; i >= 0; i--)
            {
                SelectMax(arry,i,arry.Length);
            }
        }

        public static void SelectMax(int[] array,int rootindex,int len)
        {
            int left = 2 * rootindex + 1;
            int right = 2 * rootindex + 2;

    
            int large = rootindex;
   
            if (left < len && array[left] > array[large])  //与左子节点进行比较
            {
                large = left;
            }
            if (right < len && array[right] > array[large])    //与右子节点进行比较
            {
                large = right;
            }

            if (rootindex != large)//有变化
            {
                //当前根节点和large这个节点换位置
                //交换数值
                Swap(ref array, rootindex, large);

                SelectMax(array,large,len);
            }
        }
        /// <summary>
        /// 交换元素
        /// </summary>
        public static void Swap(ref int[] array,int currentindex,int largeindex)
        {
            int temp = array[currentindex];
            array[currentindex] = array[largeindex];
            array[largeindex] = temp;
        }
    }
}
using System;

namespace _35._搜索插入位置
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }

            return nums.Length;
        }

        /// <summary>
        /// 二分法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsertMid(int[] nums, int target)
        {
            int n = nums.Length;
            int left = 0;
            int right = n - 1;

            while (left<=right)
            {
                //中间位置索引
                var midindex=left + ((right - left) / 2);// 防止溢出 等同于(left + right)/2
                //target在中间 和 右边之间
                if (target > nums[midindex])
                {
                    left = midindex + 1;
                }
                else if (target < nums[midindex])
                {
                    right = midindex - 1;
                }
                else
                {
                    return midindex;
                }
            }

            return right + 1;
        }
    }
}

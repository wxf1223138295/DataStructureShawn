using System;

namespace _209._长度最小的子数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Solution s=new Solution();
            //[5,1,3,5,10,7,4,9,2,8]
            s.MinSubArrayLen(15, new int[] { 5, 1, 3, 5, 10, 7, 4, 9, 2, 8 });
        }
    }

    public class Solution
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int result = Int32.MaxValue;
            int sum = 0; // 滑动窗口数值之和
            int startindex = 0; // 滑动窗口起始位置
            int subLength = 0; // 滑动窗口的长度
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum>=s)
                {
                    subLength = i - startindex + 1;
                    //保持最小
                    result = result < subLength ? result : subLength;
                    //滑动
                    sum -= nums[startindex];
                    startindex = startindex + 1;
                }
            }

            return result==Int32.MaxValue?0:result;
        }
    }
}

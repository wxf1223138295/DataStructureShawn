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
            //右指针
            int left = 0;
            int sum = 0;
            int minlenght = Int32.MaxValue;
            //左指针
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];

                while (sum>=s)
                {
                    var sublen = left - i + 1;

                    minlenght = minlenght > sublen ? sublen : minlenght;

                    sum = sum - nums[left];
                    left++;
                }
            }
            return minlenght == Int32.MaxValue ? 0 : minlenght;
        }
    }
}

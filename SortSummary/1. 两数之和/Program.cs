using System;

namespace _1._两数之和
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
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] { };
            for (int i = 0; i < nums.Length; i++)
            {
                int fastindex = i + 1;
                while (fastindex<=nums.Length-1)
                {
                    int sum = nums[i] + nums[fastindex];
                    if (sum == target)
                    {
                        result=new int[]{i,fastindex};
                    }
                    fastindex++;
                }
            }

            return result;
        }
    }
}

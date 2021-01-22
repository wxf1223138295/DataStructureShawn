using System;

namespace _27._移除元素
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
        public int RemoveElementBaoli(int[] nums, int val)
        {
            var length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                if (val == nums[i])
                {
                    for (int j = i+1; j < length; j++)
                    {
                        nums[j - 1] = nums[j];
                    }

                    i--;
                    length--;
                }
            }

            return length;
        }
        public int RemoveElementFastSlow(int[] nums, int val)
        {
            var length = nums.Length;
            int slowIndex = 0;
            for (int fastIndex = 0; fastIndex < length; fastIndex++)
            {
                if (val != nums[fastIndex])
                {
                    nums[slowIndex++] = nums[fastIndex];
                }
            }

            return slowIndex;
        }
    }
}

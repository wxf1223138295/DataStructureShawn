using System;
using System.Collections.Generic;

namespace _03._数组中重复的数字
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
        public int FindRepeatNumber(int[] nums)
        {
            var dic=new Dictionary<int,int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], nums[i]);
                }
                else
                {
                    return nums[i];
                }
            }

            return 0;
        }
    }
}

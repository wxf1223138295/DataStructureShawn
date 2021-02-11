using System;
using System.Collections.Generic;

namespace _1208._尽可能使字符串相等
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.EqualSubstring("abcd", "bcdf", 3);
            Console.WriteLine("Hello World!");
        }
    }


    public class Solution
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            var sa=s.ToCharArray();

            var ta = t.ToCharArray();

            var len = sa.Length;

            List<int> diff = new List<int>();
            for (int i = 0; i < len; i++)
            {
                diff.Add(Math.Abs(sa[i] - ta[i]));
            }

            int result = 0;
            int start = 0, end = 0;

            int sum = 0;

            while (end < len)
            {
                sum += diff[end];
                while (sum>maxCost)
                {
                    sum -= diff[start];
                    start++;
                }
                result = Math.Max(result, end - start + 1);
                end++;
            }

            return result;

        }
    }
}

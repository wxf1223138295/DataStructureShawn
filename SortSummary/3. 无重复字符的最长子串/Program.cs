using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._无重复字符的最长子串
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
        public int LengthOfLongestSubstring(string s)
        {
            var arry=s.ToArray();

            List<int> list=new List<int>();
            for (int i = 0; i < arry.Length; i++)
            {
               

                while (list.Any())
                {

                }
            }
        }
    }
}

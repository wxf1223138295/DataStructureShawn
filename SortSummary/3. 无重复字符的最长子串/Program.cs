using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._无重复字符的最长子串
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            s.LengthOfLongestSubstring(" ");
        }
    }
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var arry=s.ToArray();
            int maxlength = 0;
            Queue<string> list=new Queue<string>();

            //右指针
            int startindex = 0;

            //左指针
            for (int i = 0; i < arry.Length; i++)
            {
                if (i != 0)
                {
                    list.Dequeue();
                }
                
                while (startindex<=arry.Length-1&&!list.Any(p=>p==arry[startindex].ToString()))
                {
                    list.Enqueue(arry[startindex].ToString());
                    var length = startindex - i + 1;
                    maxlength = length > maxlength? length : maxlength;

                   startindex = startindex + 1;

                }
            }

            return maxlength;
        }
    }
}

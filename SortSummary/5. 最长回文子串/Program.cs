using System;
using System.Collections;

namespace _5._最长回文子串
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            s.LongestPalindrome("babad");
            Console.WriteLine("Hello World!");
        }
    }
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            //中间扩散
            string maxstr = String.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int leftindex = i;
                int rightindex = i;
                while (leftindex >= 0&& rightindex < s.Length)
                {
                    var sublen = rightindex - leftindex + 1;
                    var substr = s.Substring(leftindex, sublen);
                    if (!IsPalindrome(substr))
                    {
                        break;
                    }
                    maxstr = substr.Length > maxstr.Length ? substr : maxstr;
                    leftindex--;
                    rightindex++;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                int leftindex = i;
                int rightindex = i + 1;
                while (leftindex >= 0 && rightindex < s.Length)
                {
                    var sublen = rightindex - leftindex + 1;
                    var substr = s.Substring(leftindex, sublen);
                    if (!IsPalindrome(substr))
                    {
                        break;
                    }
                    maxstr = substr.Length > maxstr.Length ? substr : maxstr;
                    leftindex--;
                    rightindex++;
                }
            }

            return maxstr;

            //滑动窗口会超时
            // int rightindex = 0;

            //  string maxstr=String.Empty;
            //左索引
            //for (int i = 0; i < s.Length; i++)
            //{
            //    rightindex = i;
            //    while (rightindex<s.Length)
            //    {
            //        var sublen = rightindex - i + 1;
            //        var temp = s.Substring(i, sublen);
            //        if (IsPalindrome(temp))
            //        {

            //            maxstr = temp.Length > maxstr.Length ? temp : maxstr;
            //        }

            //        rightindex++;
            //    }

            //}

            //return maxstr;
        }


        private bool IsPalindrome(string str)
        {
            var len = str.Length;

            var stack=new Stack();

            var mid = len / 2;

            for (int i = 0; i < mid; i++)
            {
                stack.Push(str[i]); 
            }

            //偶数长度
            if (len % 2 == 0)
            {
                while (mid<len)
                {
                    var temp=stack.Pop();
                    if (str[mid].ToString()!=temp.ToString())
                    {
                        return false;
                    }
                   
                    mid++;
                }

                return true;
            }
            else
            {
                mid = mid + 1;
                while (mid < len)
                {
                    var temp = stack.Pop();
                    if (str[mid].ToString() != temp.ToString())
                    {
                        return false;
                    }

                    mid++;
                }
                return true;
            }
        }
    }
}

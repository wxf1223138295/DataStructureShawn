using System;
using System.Linq;

namespace 重构字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            var result=s.ReorganizeString("vvvlo");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    /// <summary>
    /// 贪心算法
    /// </summary>
    class Solution
    {
        public string ReorganizeString(string S)
        {
            if (S.Length < 2)
            {
                return S;
            }


            var counts = new int[26];

            int maxCount = 0;

            int length = S.Length;

            //26个字母的个数

            for (int i = 0; i < length; i++)
            {
                char c = S.ToCharArray().ElementAt(i);

                counts[c - 'a']++;

                maxCount = Math.Max(maxCount, counts[c - 'a']);
            }

            // 1 2  1  2  1    5/2=2   6/2=3

            if (maxCount > (length+1) / 2)
            {
                return string.Empty;
            }

            char[] reorganizeArray = new char[length];

            int enenIndex = 0, oddIndex = 1;

            //从第二个位置放置
            int halfLenth = (length) / 2;

            for (int i = 0; i < 26; i++)
            {
                char c = (char)('a' + i);

                while (counts[i] > 0 && counts[i] <= halfLenth && oddIndex < length)
                {
                    reorganizeArray[oddIndex] = c;
                    counts[i]--;
                    oddIndex += 2;
                }

                while (counts[i] > 0)
                {
                    reorganizeArray[enenIndex] = c;
                    counts[i]--;
                    enenIndex += 2;
                }

            }

            

            return string.Join("", reorganizeArray);
        }
    }
}

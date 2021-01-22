using System;
using System.Collections.Generic;
using System.Linq;

namespace _989._数组形式的整数加法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            s.AddToArrayForm(new int[] { 1, 2, 0, 0 }, 34);
        }
    }
    public class Solution
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            var str = string.Empty;
            for (int i = 0; i < A.Length; i++)
            {
                str = str + A[i];
            }

            var value1 = Convert.ToInt32(str);
            var sum = value1 + K;

            var arry = sum.ToString().ToArray();

            IList<int> list = new List<int>();

            for (int i = 0; i < arry.Length; i++)
            {
                list.Add(Convert.ToInt32(arry[i]));
            }

            return list;
        }
    }
}

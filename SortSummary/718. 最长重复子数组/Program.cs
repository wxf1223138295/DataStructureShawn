using System;
using System.Collections.Generic;
using System.Linq;

namespace _718._最长重复子数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            s.FindLength(new int[] {0,1,1,1,0 }, new int[] {1,1,1,1,1});
        }
    }
    public class Solution
    {
        public int FindLength(int[] A, int[] B)
        {
            int rightindex = 0;
        
            int max=Int32.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                
            }

            return max;
        }

        private List<int> GetIndexes(int[] arry, int num)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] == num)
                {
                    list.Add(i);
                }
            }

            return list;
        }
    }
}

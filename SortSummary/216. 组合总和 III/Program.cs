using System;
using System.Collections.Generic;
using System.Linq;

namespace _216._组合总和_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s=new Solution();
            s.CombinationSum3(3, 7);
        }
    }
    public class Solution
    {
        /// <summary>
        /// 存放结果集合
        /// </summary>
        private IList<IList<int>> ResultSet = new List<IList<int>>();

        
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            //记录每次遍历的数组
           List<int> trace = new List<int>();
            doCombination(n,0,k,1,trace);
            return ResultSet;
        }

        void doCombination(int sum,int erverysum,int len,int startindex,List<int> trace)
        {

            if (trace.Count==len)
            {
                if (sum == erverysum)
                {
                    ResultSet.Add(new List<int>(trace));
                }
                return;
            }

            for (int i = startindex; i <= 9; i++)
            {
                erverysum += i;
                trace.Add(i);
                doCombination(sum,erverysum,len,i+1,trace);
                erverysum -= i;
                trace.Remove(trace.Last());
            }

        }

       
    }
}

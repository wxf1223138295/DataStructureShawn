using System;
using System.Collections.Generic;

namespace _39_数组总和
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
        private IList<IList<int>> results = new List<IList<int>>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<int> list = new List<int>();

            BackTrace(Sort(candidates), target, 0, list, 0);
            return results;
        }

        int[] Sort(int[] myArray)
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                var preindex = i - 1;
                var current = myArray[i];
                while (preindex >= 0 && myArray[preindex] > current)
                {
                    //45, 45, 18, 53, 72, 30, 48, 93, 15, 36 
                    myArray[preindex + 1] = myArray[preindex];

                    preindex = preindex - 1;

                }
                //36, 45, 18, 53, 72, 30, 48, 93, 15, 36 
                myArray[preindex + 1] = current;
            }

            return myArray;
        }
        void BackTrace(int[] candidates, int target, int sum, List<int> trace, int startposition)
        {
            if (sum > target)
            {
                return;
            }
            //如果满足条件
            if (sum == target)
            {
                results.Add(new List<int>(trace));
                return;
            }

            for (int i = startposition; i < candidates.Length && sum + candidates[i] <= target; i++)
            {
                sum += candidates[i];
                trace.Add(candidates[i]);
                BackTrace(candidates, target, sum, trace, i);
                sum -= candidates[i];
                trace.Remove(candidates[i]);
            }
        }
    }
}

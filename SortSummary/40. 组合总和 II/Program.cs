using System;
using System.Collections.Generic;
using System.Linq;

namespace _40._组合总和_II
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
        private List<string> repeat = new List<string>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<int> list = new List<int>();
            List<bool> listbool = new List<bool>();
            foreach (var candidate in candidates)
            {
                listbool.Add(false);
            }
            BackTrace(Sort(candidates), target, 0, list, 0, listbool);
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
        void BackTrace(int[] candidates, int target, int sum, List<int> trace, int startposition, List<bool> used)
        {
            //如果满足条件
            if (sum == target)
            {
                var rt = string.Join("", trace);
                //条件2
                if (!repeat.Any(p => p == rt))
                {
                    results.Add(new List<int>(trace));
                    repeat.Add(rt);
                    return;
                }



            }

            for (int i = startposition; i < candidates.Length && sum + candidates[i] <= target; i++)
            {
                // used[i - 1] == true，说明同一树支candidates[i - 1]使用过
                // used[i - 1] == false，说明同一树层candidates[i - 1]使用过
                // 要对同一树层使用过的元素进行跳过
                if (i > 0 && candidates[i] == candidates[i - 1] && used[i - 1] == false)
                {
                    continue;
                }
                sum += candidates[i];
                used[i] = true;
                trace.Add(candidates[i]);
                BackTrace(candidates, target, sum, trace, i + 1, used);
                sum -= candidates[i];
                used[i] = false;
                trace.Remove(candidates[i]);
            }
        }
    }
}

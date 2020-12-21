using System;
using System.Collections.Generic;
using System.Linq;

namespace _46._全排列
{
    class Program
    {
        static void Main(string[] args)
        {
            var arry = new int[] {1, 2, 3};
            Solution s=new Solution();
            s.Permute(arry);
        }
    }

    public class Solution
    {
        public IList<IList<int>> results=new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums)
        { 
            // 记录「路径」
            List<int> track=new List<int>();
            TrackBack(nums, track);
            return results;
        }
        // 路径：记录在 track 中
        // 选择列表：nums 中不存在于 track 的那些元素
        // 结束条件：nums 中的元素全都在 track 中出现
        private void TrackBack(int[] nums,List<int> list)
        {
            if (list.Count == nums.Length)
            {
                results.Add(new List<int>(list));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                // 排除不合法的选择
                if (list.Contains(nums[i]))
                    continue;
                list.Add(nums[i]);

                TrackBack(nums, list);

                list.Remove(list.Last());
            }

        }
    }
}

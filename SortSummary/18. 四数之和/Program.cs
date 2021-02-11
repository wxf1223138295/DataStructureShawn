using System;
using System.Collections.Generic;

namespace _18._四数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution  s=new Solution();
            //[]
            var ts = new int[] { 0, 4, -5, 2, -2, 4, 2, -1, 4 };
            s.FourSum(ts,12);
        }
    }
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> list = new List<IList<int>>();

            //插入排序
            for (int i = 1; i < nums.Length; i++)
            {
                int preindex = i - 1;
                var currentvalue = nums[i];

                while (preindex >= 0&&nums[preindex]>currentvalue)
                {
                    nums[preindex + 1] = nums[preindex];
                    preindex--;
                }
                nums[preindex + 1] = currentvalue;
            }

            var len = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                //target
                //if(nums[i]>target) break;
                
                //去重
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                for (int j = i+1; j < nums.Length; j++)
                {
                    //去重
                    if (j > i+1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }

                    int L = j + 1;
                    int R = len - 1;

                    while (L<R)
                    {
                        int sum = nums[i] + nums[j] + nums[L] + nums[R];
                        if (sum == target)
                        {
                            IList<int> templist = new List<int>();
                            templist.Add(nums[i]);
                            templist.Add(nums[j]);
                            templist.Add(nums[L]);
                            templist.Add(nums[R]);
                            list.Add(templist);
                            while (L < R && nums[L] == nums[L + 1]) L++; // 去重
                            while (L < R && nums[R] == nums[R - 1]) R--; // 去重
                            L++;
                            R--;
                        }
                        else if(sum< target)
                        {
                            L++;
                        }
                        else if (sum > target)
                        {
                            R--;
                        }
                    }
                }
            }

            return list;
        }
    }
}

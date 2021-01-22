using System;
using System.Collections.Generic;

namespace _15._三数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Solution s=new Solution();
            int[] arry=new int[]{ -1, 0, 1, 2, -1, -4 };

            s.ThreeSum(arry);
        }
    }
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list=new List<IList<int>>();

            //对数组排序
            //插入排序
            //或
            //Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                var preindex = i - 1;
                var currentvalue = nums[i];
                while (preindex>=0&&nums[preindex]>currentvalue)
                {
                    nums[preindex + 1] = nums[preindex];
                    preindex--;
                }
                nums[preindex + 1] = currentvalue;
            }

            var length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                if(nums[i]>0) break;// 如果当前数字大于0，则三数之和一定大于0，所以结束循环
                if (i > 0 && nums[i] == nums[i - 1]) continue; // 去重

                int L = i + 1;
                int R = length - 1;
              

                while (L < R)
                {
                    int sum = nums[i] + nums[L] + nums[R];
                    if (sum == 0)
                    {
                        IList<int> templist = new List<int>();
                        templist.Add(nums[i]);
                        templist.Add(nums[L]);
                        templist.Add(nums[R]);
                        list.Add(templist);
                        while (L < R && nums[L] == nums[L + 1]) L++; // 去重
                        while (L < R && nums[R] == nums[R - 1]) R--; // 去重

                        L++;
                        R--;
                    }
                    else if(sum<0)
                    {
                        L++;
                    }
                    else if (sum > 0)
                    {
                        R--;
                    }

                }
            }

            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _88._合并两个有序数组
{
    public abstract class sds
    {

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Solution s=new Solution();
            s.Merge(new []{1,2,3},0,new []{2,5,6},0);
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            nums1=nums1.ToList().Skip(0).Take(m).ToArray();
            var ml = nums1.Length;
            var nl = nums2.Length;
            List<int> list=new List<int>();
            int i = 0;
            int j = 0;
            while (i<=ml-1&&j<=nl-1)
            {
                if (nums1[i] <= nums2[j])
                {
                    list.Add(nums1[i]);
                    i++;
                }
                else
                {
                    list.Add(nums2[j]);
                    j++;
                }

            }

            if (i > ml - 1)
            {
                for (int k = j; k < nums2.Length; k++)
                {
                    list.Add(nums2[k]);
                }
            }
            else if(j>nl-1)
            {
                for (int k = i; k < nums1.Length; k++)
                {
                    list.Add(nums2[k]);
                }
            }

            nums1 = list.ToArray();
        }
    }
}

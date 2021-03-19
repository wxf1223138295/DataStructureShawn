using System;

namespace _11.盛最多水的容器
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            s.MaxArea(new[] {1, 1});
            Console.WriteLine("Hello World!");
        }
    }
    public class Solution {
        
        public int MaxArea(int[] height)
        {
            int l = 0;
            int r = height.Length - 1;
            var maxplace = 0;
            while (l<r)
            {
                var heightvalue = Math.Min(height[l],height[r]);
                var width = r-l;
                maxplace = Math.Max(maxplace,heightvalue*width);

                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
                
            }

            return maxplace;
        }
    }
}
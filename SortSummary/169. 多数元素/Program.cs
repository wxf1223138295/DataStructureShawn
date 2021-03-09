using System;

namespace _169._多数元素
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
        public int MajorityElement(int[] nums)
        {
            //[1,4,6,2,3]
            for (int i = 1; i < nums.Length; i++)
            {
                var preindex = i - 1;  
                var currentvalue = nums[i];

                //6 >2                        4>2
                while (preindex>=0&&nums[preindex]>currentvalue)
                {
                    //  preindex=2                  preindex=1       preindex=0
                    //交换位置    1 4 6  6  3    =>      14463         12463
                    nums[preindex + 1] = nums[preindex];
                    preindex--;
                }
                nums[preindex + 1] = currentvalue;
            }

            var mid = nums.Length / 2;
            return nums[mid];
        }
    }
}

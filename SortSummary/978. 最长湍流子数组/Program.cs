using System;

namespace _978._最长湍流子数组
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
        public int MaxTurbulenceSize(int[] arr)
        {
            int left = 0, right = 0;
            var len = arr.Length;

            int result = 1;

            while (right < len - 1)
            {
                if (left == right)
                {
                    if (arr[left] == arr[left + 1])
                    {
                        left++;
                    }
                    right++;
                }
                else
                {
                    if (arr[right - 1] < arr[right] && arr[right] > arr[right + 1])
                    {
                        right++;
                    }
                    else if (arr[right - 1] > arr[right] && arr[right] < arr[right + 1])
                    {
                        right++;
                    }
                    else
                    {
                        left = right;
                    }
                }
                result = Math.Max(result, right - left + 1);

            }

            return result;

        }
    }
}

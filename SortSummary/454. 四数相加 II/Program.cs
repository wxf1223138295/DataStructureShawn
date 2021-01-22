using System;
using System.Collections.Generic;

namespace _454._四数相加_II
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
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            Dictionary<int,int> ab=new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    var sum1 = A[i] + B[j];

                    if (ab.ContainsKey(sum1))
                    {
                        ab.TryGetValue(sum1, out int count);
                        ab[sum1] = count + 1;
                    }
                    else
                    {
                        ab.Add(sum1,1);
                    }
                }
            }

            int lastcount = 0;

            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                    //用0- 字典中出先的数字   在cd中存在
                    var sum2 = C[i] + D[j];

                    var exits = 0 - sum2;

                    var isget=ab.TryGetValue(exits, out int value);

                    if (isget)
                    {
                        lastcount = lastcount + value;
                    }
                }
            }

            return lastcount;
        }
    }
}

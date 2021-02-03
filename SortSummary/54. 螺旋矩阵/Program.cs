using System;
using System.Collections.Generic;
using System.Linq;

namespace _54._螺旋矩阵
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //[[1,2,3],[4,5,6],[7,8,9]]

        }
    }

    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> list = new List<int>();


            var m = matrix.Length;

            var n = matrix[0].Length;

            int l = 0, r = n - 1, t = 0, b = m - 1;

            int sum = m * n;
            int cur = 0;

            while (cur < sum)
            {
                for (int i = l; i <= r&& cur < sum; i++)
                {
                    cur++;
                    list.Add(matrix[t][i]);
                }

                t++;

                for (int i = t; i <= b && cur < sum; i++)
                {
                    cur++;
                    list.Add(matrix[i][r]);
                }

                r--;
                for (int i = r; i >= l && cur < sum; i--)
                {
                    cur++;
                    list.Add(matrix[b][i]);
                }

                b--;
                for (int i = b; i >= t && cur < sum; i--)
                {
                    cur++;
                    list.Add(matrix[i][l]);
                }

                l++;

            }

            return list;
        }
    }
}

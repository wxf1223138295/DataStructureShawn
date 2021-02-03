using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _59._螺旋矩阵_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] str = new int[][]{new []{2,3},new []{3,4}};
            Solution s=new Solution();
            s.GenerateMatrix(3);
        }
    }
    public class Solution
    {
        public int[,] GenerateMatrix(int n)
        {
            int l = 0, r = n - 1, t = 0, b = n - 1;
           int[,] mat =new int[n,n];
           
            int num = 1, tar = n * n;
            while (num <= tar)
            {
                for (int i = l; i <= r; i++)
                {
                    mat[t,i] = num++; // left to right.

                    Console.WriteLine($"{t},{i}");
                }


                t++;
                for (int i = t; i <= b; i++)
                {
                    mat[i,r] = num++; // top to bottom.
                    Console.WriteLine($"{i},{r}");
                }

                r--;
                for (int i = r; i >= l; i--)
                {
                    mat[b,i] = num++; // right to left.
                    Console.WriteLine($"{b},{i}");
                }

                b--;
                for (int i = b; i >= t; i--)
                {
                    mat[i,l] = num++; // bottom to top.
                    Console.WriteLine($"{i},{l}");
                }

                l++;
            }

            return mat;
        }
    }
}

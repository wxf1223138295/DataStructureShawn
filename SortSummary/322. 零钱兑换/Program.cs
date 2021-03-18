using System;
using System.Collections.Generic;

namespace _322._零钱兑换
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            s.CoinChange(new int[]{1,2,5},11 );

            Console.WriteLine("Hello World!");
        }
    }
    public class Solution
    {
        //给定不同面额的硬币 coins 和一个总金额 amount。编写一个函数来计算可以凑成总金额所需的最少的硬币个数。如果没有任何一种硬币组合能组成总金额，返回 -1。
        //你可以认为每种硬币的数量是无限的。

        public int CoinChange(int[] coins, int amount)
        {
            if (coins.Length == 0)
            {
                return -1;
            }
            //表示的凑成总金额为n所需的最少的硬币个数
            int[] list = new int[amount+1];

            list[0] = 0;


            //int[][] arry=new int[2][];

            for (int mount = 1; mount <= amount; mount++)
            {
                int min = Int32.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    var currntvalue = coins[j];
                    if (mount - currntvalue >= 0 && list[mount - currntvalue] < min)
                    {
                        min = list[mount - currntvalue] + 1;

                    }
                }
                list[mount] = min;
            }

            return list[amount] == Int32.MaxValue ? -1 : list[amount];
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _888._公平的糖果棒交换
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.FairCandySwap(new int[] {1, 2}, new int[] {2, 3});
            Console.WriteLine("Hello World!");
        }


    }

    public class Solution
    {
        public int[] FairCandySwap(int[] A, int[] B)
        {
            int suma = A.Sum();
            int sumb = B.Sum();
            int avg = (sumb + suma) / 2;

            
            List<int> lista=new List<int>();  
           
            HashSet<int> set=new HashSet<int>(A);

            foreach (var itemb in B)
            {
                var result=(sumb - suma) / 2 + itemb;

                if (set.Contains(result))
                {
                    lista.Add(result);
                    lista.Add(itemb);
                }
            }


            if (lista.Count>0)
            {
                return new int[]{lista[0],lista[1]};
            }

   
            return new int[]{};
        }
    }
}

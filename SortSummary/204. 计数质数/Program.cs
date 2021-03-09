using System;

namespace _204._计数质数
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Solution s=new Solution();
            s.CountPrimes(10);
                Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int CountPrimes(int n)
        {
            int total = 0;
         
            for (int i = 2; i < n; i++)
            {
             
                    total += isPrime(i) ? 1 : 0;
                
            }

            return total;
        }

        private bool isPrime(int x)
        {
            for (int i = 2; i*i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

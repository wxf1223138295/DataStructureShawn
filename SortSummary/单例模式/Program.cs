using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Threading;

namespace 单例模式
{
    public class tst : SafeHandle
    {
        public tst(IntPtr invalidHandleValue, bool ownsHandle) : base(invalidHandleValue, ownsHandle)
        {
        }

        protected override bool ReleaseHandle()
        {
            throw new NotImplementedException();
        }

        public override bool IsInvalid { get; }
    }

    class Program
    {
        private static int Fibonacci(int i)
        {
            if (i == 1)
            {

                return 0;
            }
            if (i == 2)
            {

                return 1;
            }

            var result = Fibonacci(i - 1) + Fibonacci(i-2);

            return result;
        }
        static void Main(string[] args)
        {

            var tt=Fibonacci(8);

            Console.WriteLine(tt);

        }
    }
    class Solution
    {
        public int solution(int[] A, int K)
        {
            var length = A.Length;
            if (K > length)
            {
                return -1;
            }

            if (K == length)
            {
                return A.Sum();
            }

            for (int i = 1; i < length; i++)
            {
                var preindex = i - 1;
                var currentvalue = A[i];

                while (preindex >= 0 && A[preindex] > currentvalue)
                {
                    A[preindex + 1] = A[preindex];
                    preindex--;
                }
                A[preindex + 1] = currentvalue;

            }



            int count1 = 0;
            List<int> oushusum = new List<int>();
            for (int i = length - 1; i >= 0; i--)
            {
                if (count1 == K)
                {
                    break;
                }
                if (A[i] % 2 == 0)
                {

                    count1 = count1 + 1;
                    oushusum.Add(A[i]);
                }
            }

            if (count1 >= K)
            {
                return oushusum.Sum();
            }
            //一个偶数都没有
            if (count1 == 0)
            {
                return -1;
            }

            //偶数不够 从后面取K-1个加上 偶数刚刚最大的那个
            int count2 = 0;
            List<int> sums = new List<int>();
            for (int i = length - 1; i >= 0; i--)
            {
                if (count2 <= K - 1)
                {
                    count2 = count2 + 1;
                    sums.Add(A[i]);
                }
            }

            var sum = sums.Sum() + oushusum.Max();

            



            return sum;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
    }


    /// <summary>
    ///  饿汉式 ：第一时间创建实例,类加载就马上创建  无需
    ///  懒汉式 ：需要才创建实例，延迟加载
    /// </summary>
    public class MySingleObj
    {
        private MySingleObj()
        {

        }

        public MySingleObj obj = null;
        private readonly object lockobj = new object();

        public MySingleObj GetInstance()
        {
            if (obj == null)
            {
                obj = new MySingleObj();
            }

            return obj;
        }
        /// <summary>
        /// 线程安全
        /// </summary>
        /// <returns></returns>
        public MySingleObj GetInstance1()
        {
            //过滤掉是null的 
            if (obj == null)
            {
                //多个线程 都是null的话让一个进来
                lock (lockobj)
                {
                    //实例化一次
                    if (obj == null)
                    {
                        obj = new MySingleObj();
                    }
                }

            }

            return obj;
        }
    }
}

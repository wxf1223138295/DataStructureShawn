using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _718._最长重复子数组
{
    public abstract class Test
    {
        public virtual string func1()
        {
            return "";
        }

        public abstract string func2();
    }

    public class childclass : Test
    {
        public override string func2()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            s.FindLength(new int[] {0,1,1,1,0 }, new int[] {1,1,1,1,1});
        }
    }
    public class Solution
    {
        public int FindLength(int[] A, int[] B)
        {
            var lenA = A.Length;
            var lenB = B.Length;
            int ret = 0;
            //固定B 从 A的尾部 和B的头部开始移动  直到 A的头部和B的尾部重合后离开

            //拆分成两段
            //固定A 
            for (int i = 0; i < lenA; i++)
            {
                //找出重合的长度
                var len=Math.Min(lenB, lenA - i);
                int maxlen = MaxLength(A,B,i,0,len);
                ret = Math.Max(ret, maxlen);
            }
            //固定B
            for (int i = 0; i < lenB; i++)
            {
                 var len = Math.Min(lenA, lenB - i);
                 int maxlen = MaxLength(A, B, 0, i, len);
                 ret = Math.Max(ret, maxlen);
            }

            return ret;
        }


        private int MaxLength(int[] A, int[] B,int startA,int startB,int sublenght)
        {
            int ret = 0, k = 0;
            for (int i = 0; i < sublenght; i++)
            {
                if (A[startA + i] == B[startB + i])
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                ret = Math.Max(ret, k);
            }
            return ret;

        }


    }
}

using System;
using System.Collections.Generic;

namespace hash一致算法
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new[] {"192.168.1.2", "192.168.1.3" , "192.168.1.4" };

            SortedDictionary<string,long> dic=new SortedDictionary<string,long>();

            for (var i = 0; i < strs.Length; i++)
            {
                var te=FNV1_32_HASH(strs[i])^31;

                dic.Add(strs[i],te);
            }
            


        }

        private static long FNV1_32_HASH(String str)
        {
            int p = 16777619;
            long hash = 2166136261L;
            for (int i = 0; i < str.Length; i++)
            {
                hash = (hash ^ str[i]) * p;
                hash += hash << 13;
                hash ^= hash >> 7;
                hash += hash << 3;
                hash ^= hash >> 17;
                hash += hash << 5;
            }

            // 如果算出来的值为负数则取其绝对值
            if (hash < 0)
                hash = Math.Abs(hash);
            return hash;
        }
    }

    //FNV1_32_HASH
    
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> dic=new Dictionary<int,int>();
            dic.Add(2,3);
            
            List<int> list1 = new List<int>
            {
                1,2,3,4,5,6,7
            };

            Hashtable hashtable=new Hashtable();

           // hashtable.Add();

            HashSet<int> hashSet1 = new HashSet<int>(list1);

            List<int> list2 = new List<int>
            {
                5,6,7,8,9,10
            };
            HashSet<int> hashSet2 = new HashSet<int>(list2);

            hashSet1.UnionWith(list2);

       
            //hashSet1.ExceptWith(list2);

            Console.ReadKey();
        }
    }
}

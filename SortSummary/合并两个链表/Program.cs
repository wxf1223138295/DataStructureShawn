using System;
using LinkedListDef;

namespace 合并两个链表
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleListNode list1=new SingleListNode(0,new SingleListNode(1,new SingleListNode(2,new SingleListNode(3,new SingleListNode(4,new SingleListNode(5))))));

            SingleListNode list2=new SingleListNode(100000,new SingleListNode(100001,new SingleListNode(100002)));


            Solution sd=new Solution();
            var result=sd.MergeInBetween(list1, 3, 4, list2);

        }
    }

    public class Solution
    {
        public SingleListNode MergeInBetween(SingleListNode list1, int a, int b, SingleListNode list2)
        {
            var currentnode1 = list1;
            int i = 0;
            while (true)
            {
                if (i == a-1)
                {
                    break;
                }

                i=i+1;
                currentnode1 = currentnode1.next;
            }

            var currentnode2 = currentnode1;

            int j = 0;
            while (true)
            {
                if (j == (b - a +2))
                {
                    break;
                }

                j = j+1;
                currentnode2 = currentnode2.next;
            }

            currentnode1.next = list2;


            while (currentnode1.next!=null)
            {
                currentnode1 = currentnode1.next;
            }

            currentnode1.next = currentnode2;

            return list1;
        }
    }
}

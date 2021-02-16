using System;
using LinkedListDef;

namespace 合并两个链表
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleListNode list1 = new SingleListNode(0, new SingleListNode(1, new SingleListNode(2, new SingleListNode(3, new SingleListNode(4, new SingleListNode(5))))));

            SingleListNode list2 = new SingleListNode(100000, new SingleListNode(100001, new SingleListNode(100002)));


            Solution sd = new Solution();
            var result = sd.MergeInBetween(list1, 3, 4, list2);

        }
    }

    public class Solution
    {
        /**
 * Definition for singly-linked list. */
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode fast=list1;
          

            //慢指针先走 a 
            int counta = 0;
            var slow = list1;

            while (counta<a-1)
            {
                slow = slow.next;
                counta++;
            }

            int countb = 0;

            while (countb<b+1)
            {
                fast = fast.next;
                countb++;
            }

            slow.next = list2;

            while (slow.next!=null)
            {
                slow = slow.next;
            }

            slow.next = fast;

            return list1;

        }
        public SingleListNode MergeInBetween(SingleListNode list1, int a, int b, SingleListNode list2)
        {
            var currentnode1 = list1;
            int i = 0;
            while (true)
            {
                if (i == a - 1)
                {
                    break;
                }

                i = i + 1;
                currentnode1 = currentnode1.next;
            }

            var currentnode2 = currentnode1;

            int j = 0;
            while (true)
            {
                if (j == (b - a + 2))
                {
                    break;
                }

                j = j + 1;
                currentnode2 = currentnode2.next;
            }

            currentnode1.next = list2;


            while (currentnode1.next != null)
            {
                currentnode1 = currentnode1.next;
            }

            currentnode1.next = currentnode2;

            return list1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace 合并两个有序链表
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            Solution ssd = new Solution();
            ssd.MergeTwoLists(l1, l2);
        }
    }
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

    public class Solution
    {
        public ListNode MergeTwoListsRecursion(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {
                l1.next = MergeTwoListsRecursion(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoListsRecursion(l1, l2.next);
                return l2;
            }

        }


        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null&&l2==null)
            {
                return null;
            }

            if (l1 == null || l2 == null)
            {
                return l1 == null ? l2 : l1;
            }

            var dic = new List<int>();

            while (l1!=null)
            {
                dic.Add(l1.val);

                l1 = l1.next;
            }

            while (l2 != null)
            {
                dic.Add(l2.val);

                l2 = l2.next;
            }

            dic = dic.OrderBy(p=>p).ToList();


            var head = new ListNode();
            var pre = head;
            var point = head;
            dic.ForEach(p =>
            {
                point.val = p;
                point.next = new ListNode();
                pre = point;
                point = point.next;
            });

            pre.next = null;

            return head;
        }
    }
}

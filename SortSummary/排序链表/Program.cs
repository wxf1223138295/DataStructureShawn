using System;

namespace 排序链表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
    //进阶：
    //你可以在 O(n log n) 时间复杂度和常数级空间复杂度下，对链表进行排序吗？
    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            return SortList(head, null);
        }
        public ListNode SortList(ListNode head, ListNode tail)
        {
            if (head == null)
            {
                return head;
            }
            if (head.next == tail)
            {
                head.next = null;
                return head;
            }
            ListNode slow = head, fast = head;
            while (fast != tail)
            {
                slow = slow.next;
                fast = fast.next;
                if (fast != tail)
                {
                    fast = fast.next;
                }
            }
           var midnode = slow;

           var list1= SortList(head, midnode);
           var list2 = SortList(midnode, tail);
           var reusult= MergeTwoListsRecursion(list1, list2);

            return reusult;
        }
        /// <summary>
        /// 合并两个有序链表
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
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
        public ListNode MegerNode(ListNode list1,ListNode list2)
        {
            ListNode sentainl = new ListNode(0);

            ListNode temp = sentainl, temp1 = list1, temp2 = list2;

            while (temp1 != null && temp2 != null)
            {
                if (temp1.val <= temp2.val)
                {
                    temp.next = temp1;
                    temp1 = temp1.next;
                }
                else
                {
                    temp.next = temp2;
                    temp2 = temp2.next;
                }

                temp = temp.next;
            }

            if (temp1 != null)
            {
                temp.next = temp1;
            }
            else if (temp2 != null)
            {
                temp.next = temp2;
            }

            return sentainl.next;

        }
      
    }
}

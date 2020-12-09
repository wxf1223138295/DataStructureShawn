using System;

namespace 两两交换链表中的节点
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

    public class Solution
    {
        /// <summary>
        /// 递归
        /// 第一次交换 新头是head的next
        /// head的next 重复之前的操作
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode newhead = head.next;
            head.next = SwapPairs(newhead.next);
            newhead.next = head;
            return newhead;
        }
    }
}

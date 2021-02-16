using System;

namespace 两两交换链表中的节点
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);


            node.next = new ListNode(2);

            node.next.next = new ListNode(3);

            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);

            Solution s=new Solution();
            var t=s.SwapPairs(node);
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

            Console.WriteLine($"前：{head.val} new {newhead.val}");
            head.next = SwapPairs(newhead.next);
            Console.WriteLine($"后1：{head.val} new {newhead.val}");
            newhead.next = head;
            Console.WriteLine($"后2：{head.val} new {newhead.val}");
            return newhead;
        }
    }
}

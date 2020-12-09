using System;

namespace 移除链表元素
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(1);
            Solution s = new Solution();
            s.RemoveElements(node,1);
        }
    }

    /**
 * Definition for singly-linked list. */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        //哨兵节点
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode sentinel = new ListNode(0);
            sentinel.next = head;

            ListNode prev = sentinel;
            ListNode cur = head;

            while (cur != null)
            {
                if (cur.val == val)
                {
                    prev.next = cur.next;
                }
                else
                {
                    prev = cur;
                }
                cur = cur.next;
            }

            return sentinel.next;
        }
    }
}

using System;

namespace _203._移除链表元素
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
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode pre=new ListNode(0);

            pre.next = head;

            var temp = head;
            ListNode prev = pre;
            while (temp != null)
            {
                if (temp.val==val)
                {
                    prev.next = temp.next;
                }
                else
                {
                    prev = prev.next;
                   
                }
                temp = temp.next;
            }

            return pre.next;
        }
    }
}

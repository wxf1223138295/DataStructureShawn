using System;
using System.Collections.Generic;

namespace _142._环形链表_II复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /**
 * Definition for singly-linked list.*/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            //有个快慢指针判断是否有环
            ListNode fast = head;
            ListNode slow = head;

            while (fast!=null&&fast.next!=null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    break;
                }
            }

            if (fast != slow)
            {
                return null;
            }

            //x + y = n (y + z)
            // n=1  x=z

            //set fastpoint to head
            //exsit cycle
            fast = head;

            while (fast!=slow)
            {
                fast = fast.next;
                slow = slow.next;
            }

            return fast;
        }
    }
}

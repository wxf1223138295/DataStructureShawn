﻿using System;

namespace 环路检测
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
            if (head == null||head.next==null)
            {
                return null;
            }

            ListNode fast = head;
            ListNode slow = head;

            while (fast!=null&&fast.next!=null)
            {
               
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    break;
                }
            }

            if (fast != slow)
            {
                return null;
            }

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

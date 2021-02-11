using System;

namespace _142._环形链表_II
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
            if (head == null || head.next == null)
            {
                return null;
            }

            var fastpoint = head;
            var slowpoint = head;

            while(fastpoint!=null&&fastpoint.next!=null)
            {
                fastpoint = fastpoint.next.next;
                slowpoint = slowpoint.next;

                if (fastpoint == slowpoint) 
                {
                    break;
                }
            }
            //环 y+z   直  x
            //(x + y) * 2 = x + y + n (y + z)
            //两边消掉一个（x+y）: x + y = n (y + z)
            if (fastpoint != slowpoint)
            {
                return null;
            }
            fastpoint = head;

            while (fastpoint != slowpoint)
            {
                fastpoint = fastpoint.next;
                slowpoint = slowpoint.next;
            }

            return fastpoint;
        }
    }
}

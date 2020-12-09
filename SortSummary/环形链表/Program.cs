using System;

namespace 环形链表
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
        public bool HasCycle(ListNode head)
        {
            if (head == null||head.next==null)
            {
                return false;
            }
            var fastpoint = head;
            var slowpoint = head;

            while (fastpoint != null && fastpoint.next != null)
            {
                fastpoint = fastpoint.next.next;
                slowpoint = slowpoint.next;
                if (slowpoint == fastpoint)
                {
                    break;
                }

            }

            if (fastpoint != slowpoint)
            {
                return false;
            }

            fastpoint = head;
            while (fastpoint != slowpoint)
            {
                fastpoint = fastpoint.next;
                slowpoint = slowpoint.next;
            }

            return true;

        }
    }


}

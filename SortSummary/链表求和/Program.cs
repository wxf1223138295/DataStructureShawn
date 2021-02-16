using System;

namespace 链表求和
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
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode prehead=new ListNode(0);
            ListNode head = prehead;
            int sum = 0;
            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                sum = 0;
                if (l1 != null)
                {
                    sum = sum + l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum = sum + l2.val;
                    l2 = l2.next;
                }

                sum = sum + carry;

                head.next=new ListNode(sum%10);
                carry =sum/10 ;

                head = head.next;
            }

            return prehead.next;
        }
    }
}

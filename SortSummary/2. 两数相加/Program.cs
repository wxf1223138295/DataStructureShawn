using System;

namespace _2._两数相加
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
            var head1 = l1;
            var head2 = l2;

            var pre = new ListNode(0);
            var current = pre;

            int carry = 0;

            while (head1 != null || head2 != null)
            {
                var val1 = head1 != null ? head1.val : 0;
                var val2 = head2 != null ? head2.val : 0;

                int sum = val1 + val2+carry;

                var value = sum % 10;
                carry = sum / 10;
                ListNode node=new ListNode(value);

                current.next = node;

                current = current.next;

                if (head2 != null)
                {
                    head2 = head2.next;
                }

                if (head1 != null)
                {
                    head1 = head1.next;
                }
                  
            }
            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return pre.next;
        }
    }
}

using System;

namespace _19._删除链表的倒数第_N_个结点
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
            var ss = s.RemoveNthFromEnd(node,3);
            Console.WriteLine("Hello World!");
        }
    }
    /**
 * Definition for singly-linked list.*/
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 
    public class Solution
    {
        private int count = 0;
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var pre=new ListNode(0);
            pre.next = head;
            return RemoveNode(head, pre, n);
        }

        private ListNode RemoveNode(ListNode head,ListNode pre, int n)
        {
            if (head == null)
            {
                return head;
            }
           // Console.WriteLine($"前：{head.val} {pre.val}");
            var tr = RemoveNode(head.next, pre.next, n);

           // Console.WriteLine($"后：{head.val} --- ---{pre.val}");
            count++;

            if (count == n)
            {
                pre.next = head.next;
            }
            return pre.next;
        }
    }
}

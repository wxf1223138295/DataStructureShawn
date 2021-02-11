using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace _92._反转链表_II
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node=new ListNode(3);
            node.next=new ListNode(5);
            
            Solution s=new Solution();
            s.ReverseBetween(node, 1, 2);
            Console.WriteLine("Hello World!");
        }
    }


    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
  
            if (head == null|| m == n)
            {
                return head;
            }

      
            ListNode pre = new ListNode(0);
            pre.next = head;
            ListNode current = head;
            ListNode tail = null;
            int i = 1;
            while (i<m)
            {
                current = current.next;
                pre = pre.next;
                i++;
            }

            var len = n - m;

            var temp = current;
            int j = 0;
            while (j< len)
            {
                temp = temp.next;
                j++;
            }

            tail = temp.next;

            ListNode pre2=null;
            int k = 0;
            while (k<=len)
            {
                var temp2 = current.next;

                if (k == 0)
                {
                    current.next = tail;
                }
                else
                {
                    current.next = pre2;
                }
                

                pre2 = current;
                current = temp2;

            }

            pre.next = pre2;

            

            return head;
        }
    }
}

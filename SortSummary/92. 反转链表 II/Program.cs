using System;
using System.Collections;
using System.Collections.Generic;

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
            //方法1 迭代
            if (head == null)
            {
                return head;
            }

            
        }
    }
}

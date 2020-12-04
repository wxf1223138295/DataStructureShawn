using System;
using System.Collections.Generic;
using System.Linq;

namespace 移除重复节点
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /**
 * Definition for singly-linked list.
     * */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode RemoveDuplicateNodes(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            List<int> currentvalues = new List<int>();
            currentvalues.Add(head.val);
            var temp1 = head;
        
            while (temp1.next!=null)
            {
                if (currentvalues.Any(p=>p==temp1.next.val))
                {
                    temp1.next = temp1.next.next;
                }
                else
                {
                    currentvalues.Add(temp1.next.val);
                    temp1 = temp1.next;
                }      
            }

            return head;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace 删除排序链表中的重复元素
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(2);
            node.next.next.next = new ListNode(3);
            node.next.next.next.next = new ListNode(1);
            node.next.next.next.next.next = new ListNode(4);
            Solution solution = new Solution();
            solution.DeleteDuplicates(node);
        }
    }
    /*
  * Definition for singly-linked list.*/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            //方法 1   额外空间
            //if (head == null)
            //{
            //    return head;
            //}
            //var list = new List<int>();
            //list.Add(head.val);
            //var temp = head;

            //while (temp.next != null)
            //{
            //    if(list.Any(p=>p== temp.next.val))
            //    {
            //        temp.next = temp.next.next;
            //    }
            //    else
            //    {
            //        list.Add(temp.next.val);
            //        temp = temp.next;
            //    }


            //}

            //return head;

            //方法二

            var current = head;
            while (current!=null&&current.next!=null)
            {
                if (current.next.val == current.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return head;
        }
    }
}

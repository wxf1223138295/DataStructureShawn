using System;

namespace 两个链表的第一个公共节点
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
    /// <summary>
    /// 双指针
    /// </summary>
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            var pointa = headA;
            var pointb = headB;



            while (pointa != pointb)
            {
                pointa = pointa!=null? pointa.next:headB;
                pointb = pointb!=null? pointb.next:headA;
              
            }

            return pointa;
        }
    }
}

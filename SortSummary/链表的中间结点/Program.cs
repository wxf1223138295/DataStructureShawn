using System;

namespace 链表的中间结点
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }

        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {

                //计算链表长度
                //var len = 0;
                //while (head!=null)
                //{
                //    len = len + 1;
                //    head = head.next;
                //}

                //if (len == 0)
                //{
                //    return null;
                //}

                ListNode fast = head;
                ListNode slow = head;
                while (fast != null && fast.next != null) 
                {
                    fast = fast.next;
                    fast = fast.next;
                    slow = slow.next;
                }


                return slow;

            }
        }
    }
}

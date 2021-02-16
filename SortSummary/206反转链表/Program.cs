using System;

namespace _206反转链表
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
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            var result = ReverseNode(null, head);
            return result;
        }

        public ListNode ReverseList1(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode cur = head;
            ListNode pre = null;

            while (cur != null)
            {
                //保存后面的节点
                var temp = cur.next;

                //反转
                cur.next = pre;

                pre = cur;

                //继续

                cur = temp;
            }

            return pre;
        }


        private ListNode ReverseNode(ListNode pre,ListNode cur)
        {
            //找终止条件 
            if (cur == null)
            {
                return pre; 
            }

            var temp = cur.next;
            cur.next = pre;

          
           return ReverseNode(cur, temp);
        }
    }
}

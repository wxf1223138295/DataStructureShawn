using System;

namespace _234回文链表
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node=new ListNode(1);
            node.next=new ListNode(2);
            node.next.next=new ListNode(3);
            node.next.next.next=new ListNode(2);
            node.next.next.next.next = new ListNode(1);


            Solution s=new Solution();
            s.IsPalindrome(node);
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
        public bool IsPalindrome(ListNode head)
        {
            //找中间节点的后半部分
            // 1  2  3  2  1
            // 1   2   2   1

            var rr=FindMid(head);

            //把后半部分的链表反转
            var temp=ResverNode(rr);
            bool result = true;
            while (true)
            {
                if (head.val != temp.val)
                {
                    result = false;
                    break;
                }

                head = head.next;
                temp = temp.next;
                if (temp == null)
                {
                    break;
                    
                }
            }

            return result;
        }

        private ListNode ResverNode(ListNode node)
        {
            if (node.next==null)
            {
                return node;
            }

            var last = ResverNode(node.next);

            node.next.next = node;
            node.next = null;

            return last;
        }
        private ListNode FindMid(ListNode node)
        {
            ListNode pre = node;
            ListNode last = node;

            while (pre!=null&&pre.next!=null)
            {
                pre = pre.next;
                pre = pre.next;
                last = last.next;
            }

            if (pre == null)
            {
                return last;
            }
            else
            {
                if (pre.next == null)
                {
                    return last.next;
                }
            }

            return null;
        }
    }
}

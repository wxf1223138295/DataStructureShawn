using System;
using System.Collections;

namespace 回文链表
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(3);
            node.next.next.next.next = new ListNode(2);
            node.next.next.next.next.next = new ListNode(1);
            Solution s = new Solution();
            s.IsPalindrome(node);
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
        public bool IsPalindrome(ListNode head)
        {
            //1 2 3 2 1
            //1 2 3 3 2 1

            //方法1  入栈    反转链表 比较 
            //if (head == null)
            //{
            //    return true;
            //}
            //var stack = new Stack();
            //var point = head;
            //while (point != null)
            //{
            //    stack.Push(point.val);
            //    point = point.next;
            //}

            //var current = head;
            //var isPalindrome = true;
            //while (stack.Count > 0)
            //{
            //    var value = (int)stack.Pop();

            //    if (value != current.val)
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //    else
            //    {
            //        current = current.next;
            //    }
            //}

            //return isPalindrome;

            //方法2  找中间节点 对折比较  以后半 为准
            if (head == null)
            {
                return true;
            }
            var midnode = FindMidNode(head,null);

            var needtofanzhuan = midnode.next;

            ListNode cur = needtofanzhuan;
            ListNode prev = null;

            while (cur != null)
            {
                //取后节点
                ListNode nextTemp = cur.next;
                //反转  即 当前节点的next 设置为前节点
                cur.next = prev;
                //当前节点就变成了前节点
                prev = cur;
                //往后 移动
                cur = nextTemp;
            }

            var point = head;
            //比较
            var isPalindrome = true;
            while (prev != null)
            {
                if (prev.val != point.val)
                {
                    isPalindrome=false;
                    break;
                }

            
            }

            return isPalindrome;
        }

        public ListNode FindMidNode(ListNode left, ListNode right)
        {
            ListNode fast = left;
            ListNode slow = left;
            // 
            //while (fast != right && fast.next != right)
            //{
            //    fast = fast.next;
            //    fast = fast.next;
            //    slow = slow.next;
            //}

            //有区别   偶数的时候 此mid节点 在前面   是前面的 3  -----1 2 3 3 2 1
            //在前面 有助于 next
            while (fast.next != right && fast.next.next != right)
            {
                fast = fast.next;
                fast = fast.next;
                slow = slow.next;
            }
            return slow;

        }

    }
}

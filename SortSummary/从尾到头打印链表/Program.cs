using System;
using System.Collections.Generic;
using System.IO;

namespace 从尾到头打印链表
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] drives = Directory.GetLogicalDrives();

            Solution solution=new Solution();

            ListNode node=new ListNode(1);
            node.next=new ListNode(2);
            node.next.next=new ListNode(3);
            var r=solution.ReversePrint(node);
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public int[] ReversePrint(ListNode head)
        {
            if (head == null)
            {
                return new int[]{};
            }

            List<int> list=new List<int>();

            while (true)
            {
                list.Add(head.val);
                if (head.next == null)
                {
                    break;
                }
                head = head.next;
               
               
            }

            list.Reverse();

            return list.ToArray();
        }
        //翻转链表  迭代1
        public ListNode ReverseNode1(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            //前指针
            ListNode pre = null;
            //后指针
            var current = head;

            while (current!=null)
            {
                //存储需要倒的node
                var temp = current.next;
                //把当前节点的next翻转
                current.next = pre;
                //pre 暂存 cur
                pre = current;
                //cur 访问下一节点
                current = temp;
            }

            return pre;
        }
        public ListNode ReverseNode2(ListNode head)
        {
            if (head == null||head.next==null)
            {
                return head;
            }

            var node = ReverseNode2(head.next);
            head.next.next = head;
            head.next = null;

            return node;
        }
    }
}

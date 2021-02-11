using System;

namespace _206._反转链表
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

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            //1.迭代
            ListNode current = head;
            ListNode pre = null;

            while (current!=null)
            {
                //1.保存后续需要反转的链表
                var temp = current.next;

                //2.反转
                current.next = pre;
                pre = current;

                //3.继续
                current = temp;
            }

            return pre;



        }
        public ListNode ReverseList2(ListNode head)
        {
            //2.递归
            //递归法相对抽象一些，但是其实和双指针法是一样的逻辑，同样是当cur为空的时候循环结束，不断将cur指向pre的过程。

            return ReverseListNode(null, head);

        }

        private ListNode ReverseListNode(ListNode pre,ListNode cur)
        {
            //递归结束条件
            if (cur == null)
            {
                return pre;
            }

            var temp = cur.next;
            cur.next = pre;
            // 可以和双指针法的代码进行对比，如下递归的写法，其实就是做了这两步
            // pre = cur;
            // cur = temp;
            return ReverseListNode(pre, temp);
        }
    }
}

using System;
using System.Collections.Generic;

namespace _206._反转链表
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);

      
            node.next = new ListNode(2);

            node.next.next = new ListNode(3);

            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);

            Solution s = new Solution();
           //var t= s.ReverseList(node,5);
           //var rt = s.ReverseList2(node);
           //var sd = s.ReverseList3(node,3);
          // var sd = s.ReverseListBetween(node, 2, 4);
          var sd = s.ReverseListNodefan(node);
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

        public ListNode ReverseListBetween(ListNode head,int m,int n)
        {
            if (m == 1)
            {
                return reverseN(head, n);
            }

            int k = n - m+1;
            var temp = head;
            var tem2p = head;
            ListNode nodem = null;
            //找第m个node
            int count = 0;
            while (count + 1 < m)
            {
                tem2p = temp;
                temp = temp.next;
                nodem = temp;
                count++;
            }

            var reuslt = reverseN(nodem,k);

            tem2p.next = reuslt;

            return head;

        }
        /// <summary>
        /// 反转前n个节点
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head,int n)
        {
            return reverseN(head,n);
        }

        private ListNode successor = null;
        private ListNode reverseN(ListNode head, int n)
        {
            if (n == 1)
            {
                // 记录第 n + 1 个节点
                successor = head.next;
                return head;
            }
            // 以 head.next 为起点，需要反转前 n - 1 个节点
            ListNode last = reverseN(head.next, n - 1);

            head.next.next = head;
            // 让反转之后的 head 节点和后面的节点连起来
            head.next = successor;
            return last;
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
            var last= ReverseListNode(cur, temp);



            return last;
        }

        public ListNode ReverseList3(ListNode head,int n)
        {
            //2.递归
            //递归法相对抽象一些，但是其实和双指针法是一样的逻辑，同样是当cur为空的时候循环结束，不断将cur指向pre的过程。

            int count = 0;
            var head1 = head;
            ListNode tail = null;
            while (count+1<=n)
            {
                head1 = head1.next;
                tail = head1;
                count++;
            }

            return ReverseListNode1(null, head, tail);

        }

        private ListNode ReverseListNode1(ListNode pre, ListNode cur,ListNode tail)
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
            var last = ReverseListNode1(cur, temp, tail);

          

            return last;
        }

        private ListNode tail = null;
        public ListNode ReverseListNodefan( ListNode cur)
        {
            //递归结束条件
            if (cur.next == null)
            {
                tail = cur.next;
                return cur;
            }

            Console.WriteLine($"pre :{cur.val}");
            var last= ReverseListNodefan(cur.next);
            Console.WriteLine($"after :{cur.val} --- {last.val}");
            cur.next.next = cur;
            cur.next = tail;

            return last;
        }
    }
}

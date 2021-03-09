using System;

namespace _23._合并K个升序链表
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
        /// <summary>
        /// 数组有序
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public ListNode MergeKLists(ListNode[] lists)
        {
           var result= MergeKListsCore(lists, 0, lists.Length);
           return result;
        }

        private ListNode MergeKListsCore(ListNode[] lists,int startindex,int lastindex)
        {
            if (startindex == lastindex)
            {
                return lists[startindex];
            }
            if (startindex<lastindex)
            {
                int mid = (startindex + lastindex) / 2;

                var left=MergeKListsCore(lists, startindex,mid);
                var right=MergeKListsCore(lists,mid+1,lastindex);
               return Merge2Core(left,right);
            }

            return null;
        }
        /// <summary>
        /// 合并两个有序链表
        /// </summary>
        /// <param name="leftnode"></param>
        /// <param name="rightnode"></param>
        /// <returns></returns>
        private ListNode Merge2Core(ListNode leftnode,ListNode rightnode)
        {
            var prehead=new ListNode(0);
            var head = prehead;
            var l = leftnode;
            var r = rightnode;

            while (l!=null&&r!=null)
            {
                if (l.val < r.val)
                {
                    head.next = l;
                    l = l.next;
                }
                else
                {
                    head.next = r;
                    r = r.next;
                }

                head = head.next;
            }

            //还有没比完的  也是有序的
            var last=l != null ? l : r;

            head.next = last;

            return prehead.next;
        }
    }
}

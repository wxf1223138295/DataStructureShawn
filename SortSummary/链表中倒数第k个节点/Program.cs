using System;
using LinkedListDef;

namespace 链表中倒数第k个节点
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        /// <summary>
        /// 双指针 
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public SingleListNode GetKthFromEnd(SingleListNode head, int k)
        {
            SingleListNode first = head;
            SingleListNode second = head;


            while (k-->0)
            {
                first = first.next;
            }

            while (first!=null)
            {
                first = first.next;
                second = second.next;
            }

            return second;
        }
    }
}

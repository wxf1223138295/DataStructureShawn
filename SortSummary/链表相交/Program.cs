using System;

namespace 链表相交
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {

        /// <summary>
        ///   a  长度  2     b  长度  3 
        ///   双指针  最终走的路  都是  2+3  会在null指针相遇
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode lista = headA;
            ListNode listb = headB;
            
            while(lista!=listb)
            {
                if (lista == null)
                {
                    lista = headB;
                }
                else
                {
                    lista = lista.next;
                }

                if (listb == null)
                {
                    listb = headA;
                }
                else
                {
                    listb = listb.next;
                }
            }

            return lista;
        }
    }
}

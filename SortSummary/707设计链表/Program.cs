using System;
using System.Dynamic;
using System.Net.Http.Headers;

namespace _707设计链表
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node=new ListNode(1);
           
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    public class MyLinkedList
    {

        /** Initialize your data structure here. */
        public MyLinkedList()
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {

        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {

        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {

        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {

        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {

        }
    }
















    public static class ListNodeExtension
    {
        public static int Get(this ListNode head,int index)
        {
            ListNode mock=new ListNode(0);
            mock.next = head;

            var count = Count(head);

            if (index < 0 || index > count - 1)
            {
                return -1;
            }
            ListNode curr = head;
            for (int i = 0; i < index+1; i++)
            {
                curr = curr.next;
            }

            return curr.val;
        }

        public static int Count(this ListNode head)
        {
            int len = 0;
            var point = head;
            while (point != null)
            {
                len = len + 1;

                point = point.next;
            }

            return len;
        }

        public static void AddAtHead(this ListNode head,int val)
        {
            ListNode node = new ListNode(val);
            var point = head;
            node.next = point;

            head = node;
        }

        public static void AddAtTail(this ListNode head,int val)
        {
            var point = head;
            while (point.next!=null)
            {
                point = point.next;
            }

            ListNode node=new ListNode(val);

            point.next = node;
        }
        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public static void AddAtIndex(this ListNode head, int index, int val)
        {
            if (index > Count(head) - 1)
            {
                return;
            }

            if (index < 0)
                index = 0;

            var point = head;
            for (int i = 0; i < index-1; i++)
            {
                point = point.next;
            }

            ListNode node=new ListNode(val);


            node.next = point.next;

            point.next = node;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public static void DeleteAtIndex(this ListNode head, int index)
        {

        }
    }
}

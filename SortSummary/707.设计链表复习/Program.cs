using System;

namespace _707.设计链表复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        private ListNode prev;
        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            prev = new ListNode(0);
        }

        public int Count()
        {
            int count = 0;
            var head = prev.next;
            while (head!=null)
            {
                head = head.next;
                count++;
            }

            return count;
        }
        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            //无效的索引
            if (index < 0 || index > Count() - 1)
            {
                return -1;
            }

            var head = prev.next;

            for (int i = 0; i < index; i++)
            {
                head = head.next;
            }

            return head.val;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            AddAtIndex(0,val);
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            AddAtIndex(Count(), val);
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            //index从 0 开始   index=2  对应索引 =1
            if (index > Count())
            {
                return;
            }

            if (index < 0)
                index = 0;
            var pre = prev;
            for (int i = 0; i < index; i++)
            {
                pre = pre.next;
            }

            ListNode node=new ListNode(val);

             node.next= pre.next;

             pre.next = node;

        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index > Count() - 1)
            {
                return;
            }

            if (index < 0)
            {
                return;
            }

            var head = prev.next;

            var pre = prev;

            for (int i = 0; i < index; i++)
            {
                head = head.next;
                pre = pre.next;
            }

            pre.next = head.next;
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}

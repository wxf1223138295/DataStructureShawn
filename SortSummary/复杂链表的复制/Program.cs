using System;
using System.Collections.Generic;

namespace 复杂链表的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            //新建dic 把初始的 node copy
            Dictionary<Node,Node> dictionary=new Dictionary<Node, Node>();
            var currentnode = head;
            while (currentnode!=null)
            {
                var node=new Node(currentnode.val);
                node.next = currentnode.next;

                dictionary.Add(currentnode,node);

                currentnode = currentnode.next;

            }
            currentnode = head;

            while (currentnode != null)
            {
                dictionary.GetValueOrDefault(currentnode).next = dictionary.GetValueOrDefault(currentnode.next);

                if (currentnode.random != null)
                {
                    dictionary.GetValueOrDefault(currentnode).random = dictionary.GetValueOrDefault(currentnode.random);
                }
               
                currentnode = currentnode.next;
            }

            return dictionary.GetValueOrDefault(head);
        }
    }
}

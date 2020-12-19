using System;
using System.Collections;
using System.Collections.Generic;

namespace _116._填充每个节点的下一个右侧节点指针
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            node.next = null;
            node.left = new Node(2);
            node.right = new Node(3);
            node.left.next = null;
            node.right.next = null;
            node.left.left = new Node(4);
            node.left.right = new Node(5);
            node.left.left.next = null;
            node.left.right.next = null;

            node.right.left = new Node(6);
            node.right.right = new Node(7);
            node.right.left.next = null;
            node.right.right.next = null;

            Solution s = new Solution();
            s.Connect(node);
        }
    }
    /*
// Definition for a Node.*/
    public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {

                return null;
            }
            Queue<Node> queue = new Queue<Node>();
            var root2 = root;
            queue.Enqueue(root2);

            while (queue.Count>0)
            {

                var len = queue.Count;

                var temp = new Queue<Node>();

                for (int i = 0; i < len; i++)
                {
                    var currentnode = queue.Dequeue();

                    temp.Enqueue(currentnode);
                   
                    if (currentnode.left != null)
                    {
                        queue.Enqueue(currentnode.left);
                    }
                    if (currentnode.right != null)
                    {
                        queue.Enqueue(currentnode.right);
                    }
                }


                List<Node> list = new List<Node>();

                while (temp.Count > 0)
                {
                    list.Add(temp.Dequeue());
                }

                for (int i = 0; i < list.Count-1; i++)
                {
                    if (list.Count == 1)
                    {
                        list[i].next = null;
                    }
                    else
                    {
                        list[i].next = list[i + 1];
                    }
                }
            }
            return root;
        }
    }
}

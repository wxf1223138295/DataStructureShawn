using System;
using System.Collections;
using System.Collections.Generic;

namespace _116._填充每个节点的下一个右侧节点指针复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var count = q.Count;
                List<Node> list = new List<Node>();
                for (int i = 0; i < count; i++)
                {
                    var node = q.Dequeue();

                    list.Add(node);

                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }

                if (list.Count == 1)
                {
                    list[0].next = null;
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i == list.Count - 1)
                        {
                            list[i].next = null;
                        }
                        else
                        {
                            list[i].next = list[i + 1];
                        }
                    }
                }
            }

            return root;
        }
    }
}

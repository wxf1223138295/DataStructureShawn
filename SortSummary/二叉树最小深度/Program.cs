using System;
using System.Collections.Generic;

namespace 二叉树最小深度
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /**
 * Definition for a binary tree node. */
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
            int mindepth = 1;

            while (queue.Count>0)
            {
                int len = queue.Count;
                for (int i = 0; i < len; i++)
                {
                    var currentNode = queue.Dequeue();

                    if (currentNode.left == null && currentNode.right == null)
                    {
                        return mindepth;
                    }

                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }

                    if (currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }
              
                mindepth++;

            }

            return mindepth;
        }
    }
}

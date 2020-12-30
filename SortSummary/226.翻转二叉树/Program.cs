using System;
using System.Collections.Generic;

namespace _226.翻转二叉树
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
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode InvertTree2(TreeNode root)
        {
            //递归
            if (root == null) return root;

            //交换
            var temp = root.left;
            root.left = root.right;
            root.right = temp;


            InvertTree2(root.left);
            InvertTree2(root.right);

            return root;
        }

        public TreeNode InvertTree1(TreeNode root)
        {
            //广度优先
            if (root == null) return null;

            Queue<TreeNode> q=new Queue<TreeNode>();

            q.Enqueue(root);


            while (q.Count>0)
            {
                //var size = q.Count;

            
                    var curentnode = q.Dequeue();

                    var temp=curentnode.left;
                   curentnode.left = curentnode.right;
                    curentnode.right = temp;
                    if (curentnode.left != null)
                    {
                        q.Enqueue(curentnode.left);
                    }
                    if (curentnode.right != null)
                    {
                        q.Enqueue(curentnode.right);
                    }
            }

            return root;
        }
    }
}

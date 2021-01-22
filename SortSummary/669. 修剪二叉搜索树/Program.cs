using System;

namespace _669._修剪二叉搜索树
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /* Definition for a binary tree node. */
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
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null) return null;

            if (root.val < low)
            {
                var right = TrimBST(root.right, low, high);
                return right;
            }

            if (root.val > high)
            {
                var left= TrimBST(root.left, low, high);
                return left;
            }

            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);
            return root;
        }
    }
}

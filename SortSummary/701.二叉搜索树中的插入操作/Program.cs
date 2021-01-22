using System;

namespace _701.二叉搜索树中的插入操作
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
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                TreeNode node=new TreeNode(val);
                return node;
            }

            if (root.val > val) root.left = InsertIntoBST(root.left, val);

            if (root.val < val) root.right = InsertIntoBST(root.right, val);

            return root;
        }
    }
}

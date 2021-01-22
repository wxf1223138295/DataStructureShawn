using System;
using System.ComponentModel.DataAnnotations;

namespace _450._删除二叉搜索树中的节点
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
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return root;

            if (root.val == key)
            {
                if (root.left == null && root.right == null)
                {
                    return null;
                }

                if (root.left == null && root.right != null)
                {
                    return root.right;
                }
                if (root.left != null && root.right == null)
                {
                    return root.left;
                }

              
                var tempright = root.right;

                while (tempright.left != null)
                {
                    tempright = tempright.left;
                }

                tempright.left = root.left;

                //删除
                root = root.right;
                return root;
            }

            if (root.val > key) root.left=DeleteNode(root.left, key);

            if (root.val < key) root.right = DeleteNode(root.right, key);


            return root;
        }
    }
}

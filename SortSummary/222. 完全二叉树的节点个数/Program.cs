using System;

namespace _222._完全二叉树的节点个数
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
        public int CountNodes(TreeNode root)
        {

            if (root == null) return 0;

            var leftcount=CountNodes(root.left);
            var rightcount=CountNodes(root.right);

            var count = 1 + leftcount + rightcount;
            return count;
        }


    }
}

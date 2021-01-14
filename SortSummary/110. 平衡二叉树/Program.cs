using System;

namespace _110._平衡二叉树
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
        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsBalanced(TreeNode root)
        {
            return GetHight(root)==-1?false:true;
        }
        /// <summary>
        /// 等于-1 就是不平衡
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private int GetHight(TreeNode root)
        {
            //终止条件
            if (root == null)
            {
                return 0;
            }

            int left = GetHight(root.left);
            if (left == -1)
            {
                return -1;
            }
            int right = GetHight(root.right);
            if (right == -1)
            {
                return -1;
            }

            var result=Math.Abs(left - right) > 1 ? -1 : 1+Math.Max(left,right);

            return result;
        }
    }
}

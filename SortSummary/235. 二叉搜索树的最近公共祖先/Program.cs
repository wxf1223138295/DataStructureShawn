using System;

namespace _235._二叉搜索树的最近公共祖先
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
        /// <summary>
        /// 自上而下 找到当前节点
        /// 的值在p和q之前的第一个出现
        /// 的节点就是最近的祖先
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return root;

            var currentval = root.val;

            //目标区间是q-p 在当前节点在 左边
            if (currentval > p.val && currentval > q.val)
                return LowestCommonAncestor(root.left, p, q);

            //目标区间是q-p 在当前节点在 右边
            else if (currentval < p.val && currentval < q.val)
                return LowestCommonAncestor(root.right, p, q);
            else
            {
                return root;
            }
        }
    }
}

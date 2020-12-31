using System;

namespace _104._二叉树的最大深度
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
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            //1.确定递归方法
            var leftdept = MaxDepth(root.left);
            var rightdept = MaxDepth(root.right);

            int maxdept =1+ Math.Max(leftdept, rightdept);

            //2.找出终止条件
            return maxdept;
            //3.找出单层逻辑
        }

   
    }
}

using System;
using System.Collections.Generic;

namespace _530._二叉搜索树的最小绝对差
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
        //中序遍历
        private List<int> list = new List<int>();
        public int GetMinimumDifference(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Search(root);
            int result = int.MaxValue;
            //有序集合
            for (int i = 1; i < list.Count; i++)
            {
                result = Math.Min(result,Math.Abs(list[i - 1] - list[i]));
            }

            return result;
        }
        private void Search(TreeNode root)
        {
            if (root == null) return;

            Search(root.left);

            list.Add(root.val);
            Search(root.right);


        }
    }
}

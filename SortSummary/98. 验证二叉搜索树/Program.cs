using System;
using System.Collections.Generic;

namespace _98._验证二叉搜索树
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
        //中序遍历
        private List<int> list=new List<int>();
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            Search(root);

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] >= list[i])
                {
                    return false;
                }
            }

            return true;
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

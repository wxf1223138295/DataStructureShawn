using System;
using System.Globalization;

namespace _100._相同的树
{
    class Program
    {
        static void Main(string[] args)
        {
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
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p !=null && q == null)
            {
                return false;
            }
            else if(p == null && q != null)
            {
                return false;
            }
            else if(p.val!=q.val)
            {
                return false;
            }

            var left = IsSameTree(p.left, q.left);
            var right = IsSameTree(p.right, q.right);
            var result = left && right;
            return result;
        }


    }
}

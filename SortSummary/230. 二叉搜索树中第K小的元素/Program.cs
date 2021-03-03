using System;
using System.Collections.Generic;

namespace _230._二叉搜索树中第K小的元素
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
        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null)
            {
                return 0;
            }

            List<int> orderlist=new List<int>();

            MidSort(root,orderlist);

            return orderlist[k - 1];
        }

        private void MidSort(TreeNode root, List<int> orderlist)
        {
            if (root == null)
            {
                return;
            }

            MidSort(root.left, orderlist);

            orderlist.Add(root.val);

            MidSort(root.right, orderlist);


        }
    }
}

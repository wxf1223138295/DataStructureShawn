using System;
using System.Collections.Generic;

namespace _404._左叶子之和
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /**
 * Definition for a binary tree node.*/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            List<int> list = new List<int>();

            GetValue(root, list);

            int sum = 0;
            for (var i = 0; i < list.Count; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }

        public int GetValue(TreeNode root,List<int> list)
        {
            if (root == null) return 0;

            if (root.left != null&&(root.left.left==null&&root.left.right==null))
            {
                list.Add(root.left.val);
            }

            GetValue(root.left, list);
            GetValue(root.right, list);

            return 0;
        }
    }
}

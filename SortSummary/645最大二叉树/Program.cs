using System;
using System.Collections.Generic;
using System.Linq;

namespace _645最大二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();
            int[] arry=new int[]{ 3, 2, 1, 6, 0, 5 };
            s.ConstructMaximumBinaryTree(arry);
            Console.WriteLine("Hello World!");
        }
    }

    /**
 * Definition for a binary tree node. */
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }

    public class Solution
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            var list = nums.ToList();

           return BuildMaxNode(list);

        }

        public TreeNode BuildMaxNode(List<int> list)
        {
            if (list.Count <= 0)
            {
                return null;

            }

         

            var max = list.Max();
            var index = list.IndexOf(max);
            TreeNode root = new TreeNode(max);
            List<int> leftlist=new List<int>();

            for (int i = 0; i < index; i++)
            {
                leftlist.Add(list[i]);
            }

            List<int> rightlist = new List<int>();

            for (int i = index+1; i < list.Count; i++)
            {
                rightlist.Add(list[i]);
            }

            root.left=BuildMaxNode(leftlist);
            root.right=BuildMaxNode(rightlist);

            return root;
        }
    }
}

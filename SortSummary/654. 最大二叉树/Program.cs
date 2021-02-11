using System;
using System.Collections.Generic;

namespace _654._最大二叉树
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
        Dictionary<int,int> dic=new Dictionary<int, int>();
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return traversal(nums, 0, nums.Length);
        }

        private TreeNode traversal(int[] nums,int leftindex,int rignhtindex)
        {
            if (leftindex >= rignhtindex)
            {
                return null;
            }

            int maxindex = leftindex;
            for (int i = leftindex+1; i < rignhtindex; i++)
            {
                if (nums[i] > nums[maxindex]) maxindex = i;
            }

            TreeNode root = new TreeNode(nums[maxindex]);

            // 左闭右开：[left, maxValueIndex)
            root.left = traversal(nums, leftindex, maxindex);
            // 左闭右开：[maxValueIndex + 1, right)
            root.right = traversal(nums, maxindex + 1, rignhtindex);

            return root;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _897._递增顺序查找树
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node=new TreeNode(2);
            node.left=new TreeNode(1);
            node.right = new TreeNode(4);
            node.right.left=new TreeNode(3);

            Solution s=new Solution();

            var rr=s.IncreasingBST(node);

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
        List<TreeNode> list=new List<TreeNode>();
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            GetMidSort(root);

            var head = list.First();

            var temp = head;


            for (var i = 1; i < list.Count; i++)
            {
                temp.left = null;

                temp.right = list[i];

                temp = temp.right;
            }

            temp.left = null;

            return head;
        }

        public void GetMidSort(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            IncreasingBST(root.left);

            list.Add(root);

            IncreasingBST(root.right);

        }
    }
}

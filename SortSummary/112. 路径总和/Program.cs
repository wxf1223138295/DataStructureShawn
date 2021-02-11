using System;
using System.Collections.Generic;
using System.Linq;

namespace _112._路径总和
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
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            List<int> stack = new List<int>();

            List<int> resultset=new List<int>();
             ToButton(root,sum,stack, resultset);

             return resultset.Count > 0;

        }

        private void ToButton(TreeNode root, int sum,List<int> list,List<int> resultset)
        {
            list.Add(root.val);

            if (root.left == null && root.right == null)
            {
                var suxm=list.Sum();
                if (suxm == sum)
                {
                    resultset.Add(sum);
                    return;
                }

                return;
            }

            if (root.left != null)
            {
                ToButton(root.left, sum, list, resultset);
                list.RemoveAt(list.Count-1);
            }

            if (root.right != null)
            {
                ToButton(root.right, sum, list, resultset);
                list.RemoveAt(list.Count - 1);
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace 二叉树的层次遍历_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> levels = new List<IList<int>>();
            if (root == null)
            {
                return levels;
            }
            Queue<TreeNode> needtoextension = new Queue<TreeNode>();
            needtoextension.Enqueue(root);

       

            while (needtoextension.Count > 0)
            {
                List<int> level = new List<int>();
                int len = needtoextension.Count;
                for (int i = 0; i < len; i++)
                {
                    var curr = needtoextension.Dequeue();

                    level.Insert(0,curr.val);
                    if (curr.right != null)
                    {
                        needtoextension.Enqueue(curr.right);
                    }
                    if (curr.left != null)
                    {
                        needtoextension.Enqueue(curr.left);
                    }
                }
                levels.Insert(0,level);
            }

            return levels;
        }
    }
}

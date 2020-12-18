using System;
using System.Collections.Generic;

namespace 二叉树的层平均值
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
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> resultlist=new List<double>();
            if (root == null) return resultlist; 
            Queue<TreeNode> queue=new Queue<TreeNode>();
            
            queue.Enqueue(root);
            
            while (queue.Count>0)
            {
                int len = queue.Count;
                double sumlevel = 0;
                int count = 0;
                for (int i = 0; i < len; i++)
                {
                    var currentnode = queue.Dequeue();
                    sumlevel = sumlevel + currentnode.val;
                    count = count + 1;
                    if (currentnode.left != null)
                    {
                        queue.Enqueue(currentnode.left);
                    }
                    if (currentnode.right != null)
                    {
                        queue.Enqueue(currentnode.right);
                    }
                }

                var arglevel = sumlevel / count;
                resultlist.Add(arglevel);

            }

            return resultlist;
        }
    }
}

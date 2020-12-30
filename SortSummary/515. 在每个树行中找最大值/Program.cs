using System;
using System.Collections.Generic;
using System.Linq;

namespace _515._在每个树行中找最大值
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
        public IList<int> LargestValues(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            Queue<TreeNode> q=new Queue<TreeNode>();

            q.Enqueue(root);

            IList<int> result= new List<int>();

            while (q.Count>0)
            {
                var size = q.Count;

                //把每一层的值加入
                IList<int> temp=new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var node=q.Dequeue();
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                    temp.Add(node.val);
                }

                result.Add(temp.Max());
            }

            return result;
        }
    }
}

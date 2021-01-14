using System;
using System.Collections.Generic;

namespace _513.找树左下角的值
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
        public int FindBottomLeftValue(TreeNode root)
        {
            int result = 0;
            if (root == null)
            {
                return result;
            }
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);
          
            while (queue.Count>0)
            {
                int len = queue.Count;
                for (int i = 0; i < len; i++)
                {
                    var tt = queue.Dequeue();

                    if (i == 0) result = tt.val;

                    if (tt.left != null)
                    {
                        queue.Enqueue(tt.left);
                    }
                    if (tt.right != null)
                    {
                        queue.Enqueue(tt.right);
                    }

                }
            }

            return result;
        }
    }
}

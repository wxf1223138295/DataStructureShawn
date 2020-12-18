using System;
using System.Collections.Generic;
using System.Linq;

namespace 二叉树的右视图
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode=new TreeNode(1);
            treeNode.left = new TreeNode(2);
            treeNode.right=new TreeNode(3);
            treeNode.left.right = new TreeNode(4);


         

            Solution s=new Solution();
            s.RightSideView(treeNode);
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
        public IList<int> RightSideView(TreeNode root)
        {
            List<int> rightviewresult = new List<int>();
            if (root == null)
            {
                return rightviewresult;
            }
            
            //存放每层节点
            Queue<TreeNode> queue=new Queue<TreeNode>();
            queue.Enqueue(root);


            while (queue.Count>0)
            {
                int len = queue.Count;

                List<int> level = new List<int>();

                for (int i = 0; i < len; i++)
                {
                    var currentnode = queue.Dequeue();

                    level.Add(currentnode.val);

                    if (currentnode.left != null)
                    {
                        queue.Enqueue(currentnode.left);
                    }
                    if (currentnode.right != null)
                    {
                        queue.Enqueue(currentnode.right);
                    }
                   


                }

                rightviewresult.Add(level.Last());
            }

            return rightviewresult;
        }
    }
}

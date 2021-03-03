using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _103._二叉树的锯齿形层序遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();

            TreeNode node=new TreeNode(3);
            node.left=new TreeNode(9);
            node.right=new TreeNode(20);
            node.right.left=new TreeNode(15);
            node.right.right=new TreeNode(7);

            s.ZigzagLevelOrder(node);
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
        IList<IList<int>> list=new List<IList<int>>();
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {

            ZigzagLevelOrderCore(root);
            return list;
        }

        public void ZigzagLevelOrderCore(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int levelcount = 0;

            while (queue.Count>0)
            {
                int currnentlevel = queue.Count;
                levelcount++;
                IList<int> temp=new List<int>();
                for (int i = 0; i < currnentlevel; i++)
                {
                    var currnetnode = queue.Dequeue();


                    temp.Add(currnetnode.val);
                    if (currnetnode.left != null)
                    {
                        queue.Enqueue(currnetnode.left);
                    }

                    if (currnetnode.right != null)
                    {
                        queue.Enqueue(currnetnode.right);
                    }
                }

                var tes=levelcount / 2;
                if (tes == 0)
                {
                    list.Add(temp.Reverse().ToList());
                }
                else
                {
                    list.Add(temp.ToList());
                }
            }
        }
    }
}

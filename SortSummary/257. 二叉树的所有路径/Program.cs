using System;
using System.Collections.Generic;

namespace _257._二叉树的所有路径
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
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            IList<string> list=new List<string>();
            //存放节点值
            List<int> stack=new List<int>();

            complete(root, stack,list);


            return list;
        }

        private void complete(TreeNode root, List<int> stack,IList<string> list)
        {
            stack.Add(root.val);

            if (root.left == null && root.right == null)
            {
                //走到分支底部
                string srt = string.Empty;
                for (int i = 0; i < stack.Count-1; i++)
                {
                    var value = stack[i];
                    srt = srt + value + "->";
                }

                srt = srt + stack[stack.Count - 1];

                list.Add(srt);
                return;
            }

            if (root.left != null)
            {
                complete(root.left,stack,list);
                stack.RemoveAt(stack.Count-1);
            }
            if (root.right != null)
            {
                complete(root.right, stack, list);
                stack.RemoveAt(stack.Count - 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _101._对称二叉树
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
        public bool IsSymmetric(TreeNode root)
        {
            //递归
            if (root == null) return true;

            var result = CompareNode(root.left,root.right);

            return result;
        }

        private bool CompareNode(TreeNode left, TreeNode right)
        {
            //排除null
            if (left == null && right != null)
            {
                return false;
            }
            else if (left != null && right == null)
            {
                return false;
            }
            else if (left == null && right == null)
            {
                return true;
            }
            //排除数不等的
            else if (left.val != right.val)
            {
                return false;
            }
            //递归
            //比较二叉树外侧是否对称：传入的是左节点的左孩子，右节点的右孩子。
            var waice=CompareNode(left.left, right.right);
            //比较内测是否对称，传入左节点的右孩子，右节点的左孩子。
            var neice = CompareNode(left.right, right.left);

            var result = waice && neice;
            //像后序遍历
            return result;
         

        }

        /// <summary>
        /// 迭代法
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric2(TreeNode root)
        {
            //递归
            if (root == null) return true;

            Queue<TreeNode> queue=new Queue<TreeNode>();

            if (root.left == null && root.right == null)
            {
                return true;
            }

            if (root.left ==null && root.right != null)
            {
                return false;
            }
            else if (root.right == null && root.left != null)

            {
                return false;
            }
            //排除数不等的
            else if (root.left.val != root.right.val)
            {
                return false;
            }

            queue.Enqueue(root.left);
            queue.Enqueue(root.right);

            while (queue.Count>0)
            {
                var size = queue.Count;
                //一下出队列2个
                var left = queue.Dequeue();
                var right = queue.Dequeue();

                if (left == null && right == null)
                {
                    continue;
                }

                //排除null
                if (left == null && right != null)
                {
                    return false;
                }
                else if (left != null && right == null)
                {
                    return false;
                }
                //排除数不等的
                else if (left.val != right.val)
                {
                    return false;
                }
                //左右左右的加入队列
                queue.Enqueue(left.left);
                queue.Enqueue(right.right);
                queue.Enqueue(left.right);
                queue.Enqueue(right.left);
                
            }

            return true;
        }
    }


}

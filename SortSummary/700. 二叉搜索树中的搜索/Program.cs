using System;

namespace _700._二叉搜索树中的搜索
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
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            return getnode(root, val);
        }
        /// <summary>
        /// 二叉搜索树是一个有序树：
        /// 若它的左子树不空，则左子树上所有结点的值均小于它的根结点的值；
        /// 若它的右子树不空，则右子树上所有结点的值均大于它的根结点的值；
        /// 它的左、右子树也分别为二叉搜索树
        /// </summary>
        /// <param name="node"></param>
        /// <param name="vat"></param>
        /// <returns></returns>
        private TreeNode getnode(TreeNode node, int vat)
        {
            if (node == null)
            {
                return null;
            }

            var currentvalue = node.val;
            if (currentvalue == vat)
            {
                return node;
            }

            if(node.val>vat) return getnode(node.left,vat);
            if (node.val < vat) return getnode(node.right, vat);

            return null;
        }
    }
}

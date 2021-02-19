using System;

namespace _114._二叉树展开为链表
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
        public void Flatten(TreeNode root)
        {
            if (root == null) return;

            Flatten(root.left);
            Flatten(root.right);

            //找出当前节点的节点
            TreeNode left = root.left;
            TreeNode right = root.right;

           //把当前节点的左节点 设置null  右节点指向  左节点
            root.right = left;
            root.left = null;

            //修改完之后把现在的右节点指向原来的右节点
            var p = root;
            while (p.right!=null)
            {
                p = p.right;
            }

            p.right = right;
        }


    }
}

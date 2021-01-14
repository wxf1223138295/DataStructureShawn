using System;
using System.Collections.Generic;

namespace _106._从中序与后序遍历序列构造二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
           Solution s=new Solution();
           var inorder = new int[]{ 9, 3, 15, 20, 7 };

           var postorder = new int[] { 9, 15, 7, 20, 3 };

           s.BuildTree(inorder, postorder);
        }
    }

    /* Definition for a binary tree node. */
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        Dictionary<int,int> dic=new Dictionary<int, int>();
        private int[] post;
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            for (int i = 0; i < inorder.Length; i++)
            {
                dic.Add(inorder[i],i);
            }

            post = postorder;
            return GetBinaryTree(0, inorder.Length-1, postorder, 0, postorder.Length-1);
        }

        private TreeNode GetBinaryTree(int instart, int inend, int[] postorder, int poststart, int postend)
        {
            if (postend<poststart||inend<instart)
            {
                return null;
            }
            //根据后序遍历找到根节点
            var rootval = post[postend];
            TreeNode root = new TreeNode(rootval);


            // 叶子节点
            if (postorder.Length == 1) 
                return root;

            //根据中序 用根节点一分为二数组
            int in_root = dic[rootval];
            
            //中序遍历的结果是[4,2,5,1,6,3,7]
            //后序遍历       [4,5,2,6,7,3,1]
            //获取前半个分支的长度
            int leftlen = in_root - instart;

            root.left = GetBinaryTree( instart, in_root-1, postorder, poststart, poststart+leftlen - 1);
            root.right = GetBinaryTree( in_root + 1, inend, postorder, poststart + leftlen, postend - 1);

            return root;
        }
    }
}

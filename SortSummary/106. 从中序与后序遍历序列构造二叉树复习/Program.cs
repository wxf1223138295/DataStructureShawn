using System;
using System.Linq;

namespace _106._从中序与后序遍历序列构造二叉树复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.BuildTree(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 });
            Console.WriteLine("Hello World!");
        }
    }
    /**
 * Definition for a binary tree node. */
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int x) { val = x; }
 }

    public class Solution
    {

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            var result= BuildTreeCore(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1);
            return result;
        }

        public TreeNode BuildTreeCore(int[] inorder,int instart,int inend, int[] postorder,int poststart,int postend)
        {
            if (poststart > postend||instart>inend)
            {
                return null;
            }

            //找根节点
            var rootvalue = postorder[postend];
            TreeNode root=new TreeNode(rootvalue);


            var inrootindex=inorder.ToList().IndexOf(rootvalue);
            
            int leftlen = inrootindex-instart;


            root.left = BuildTreeCore(inorder, instart, inrootindex-1,postorder, poststart, poststart + leftlen-1);
            root.right = BuildTreeCore(inorder, inrootindex+1, inend, postorder, poststart+leftlen, postend - 1);

            return root;
        }
    }
}

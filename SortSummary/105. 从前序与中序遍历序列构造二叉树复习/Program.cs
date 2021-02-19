using System;
using System.Linq;

namespace _105._从前序与中序遍历序列构造二叉树复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.BuildTree(new int[] {3, 9, 20, 15, 7}, new int[] {9, 3, 15, 20, 7});
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
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTreeCore(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
        }

        public TreeNode BuildTreeCore(int[] preorder,int preindex,int preendindex, int[] inorder,int inindex,int inendindex)
        {
            if (preindex> preendindex)
            {
                return null;
            }

            //通过前序遍历确定根节点 
            var rootvalue = preorder[preindex];
            var root=new TreeNode(rootvalue);

            //通过中序遍历  找左右的  中序遍历 ，并且确定左右长度
            var inindexvalue=inorder.ToList().IndexOf(rootvalue);
            var inlen = inorder.Length;
            //确定前序遍历的左右部分
            var leftlen = inindexvalue- inindex;
            //var rightlen= inlen - inindexvalue - 1;

            

            root.left = BuildTreeCore(preorder, preindex+1, preindex + leftlen,inorder, inindex, inindexvalue-1);
            root.right = BuildTreeCore(preorder, preindex + leftlen+1, preendindex, inorder, inindexvalue+1, inendindex);

            return root;
        }
    }
}

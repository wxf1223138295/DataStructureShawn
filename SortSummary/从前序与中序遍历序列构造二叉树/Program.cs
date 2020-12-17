using System;

namespace 从前序与中序遍历序列构造二叉树
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
   

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
          return GetBinaryTree(preorder, 0, preorder.Length, inorder, 0, inorder.Length);
      }

      private TreeNode GetBinaryTree(int[] preorder, int prestart,int preend,int[] inorder,int instart,int inend)
      {
          if (prestart == preend)
          {
              return null;

          }
          //根据前序获取节点
          int rootval = preorder[prestart];
          TreeNode root = new TreeNode(rootval);
            //根据中序 用根节点一分为二数组
            int in_root = 0;
            for (int i = instart; i < inend; i++)
            {
                if (rootval == inorder[i])
                {
                    in_root = i;
                    break;
                }
            }
            //获取前半个分支的长度
            int leftlen = in_root - instart;

            //那对于前序二叉树的话  
            //前序遍历的结果是: [1,2,4,5,3,6,7]
            //中序遍历的结果是:[4,2,5,1,6,3,7]
            //这里做半个分支 4 2  5 leftlen=3
            //对于前序排序 应该是根节点后 leftlen个
            //所以


            root.left = GetBinaryTree(preorder,prestart+1,prestart+1+leftlen,inorder, instart, in_root);
            root.right = GetBinaryTree(preorder, prestart + 1 + leftlen, preend, inorder, in_root + 1, inend);

            return root;
      }
  }
}

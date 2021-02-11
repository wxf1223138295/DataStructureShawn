using System;
using System.Collections.Generic;
using System.Linq;

namespace _113._路径总和_II
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
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            IList<IList<int>> resultset = new List<IList<int>>();
            if (root == null)
            {
                return resultset;
            }

            List<int> stack = new List<int>();

         
            ToButton(root, sum, stack, resultset);

            return resultset;

        }
        /// <summary>
        /// 二叉树  回溯+递归
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <param name="list"></param>
        /// <param name="resultset"></param>
        private void ToButton(TreeNode root, int sum, List<int> list, IList<IList<int>> resultset)
        {
            list.Add(root.val);

            if (root.left == null && root.right == null)
            {
                var suxm = list.Sum();
                if (suxm == sum)
                {
                    List<int> temp=new List<int>();
                    list.ForEach(p =>
                    {
                        temp.Add(p);
                    });

                    resultset.Add(temp);
              
                }

                return;
            }

            if (root.left != null)
            {
                ToButton(root.left, sum, list, resultset);
                list.RemoveAt(list.Count - 1);
            }

            if (root.right != null)
            {
                ToButton(root.right, sum, list, resultset);
                list.RemoveAt(list.Count - 1);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _501._二叉搜索树中的众数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        public int[] FindMode(TreeNode root)
        {
            List<int> set=new List<int>();

            if (root == null)
            {
                return set.ToArray();
            }
            Dictionary<int,int> dic=new Dictionary<int, int>();

            Search(root,dic);

            var list=dic.OrderByDescending(p => p.Value).Select(p => p.Value);

            var max = list.First();

            var maxcount=list.Count(p => p == max);
            if (maxcount > 1)
            {
                var temp=dic.Where(p => p.Value == max).Select(p => p.Key);
                set = temp.ToList();
            }
            else
            {
                var temp = dic.Where(p => p.Value == max).Select(p => p.Key);
                set.Add(temp.First());
            }
            

            return set.ToArray();
        }

        private void Search(TreeNode root, Dictionary<int, int> dic)
        {
            if (root == null) return;

            int temp;
            var result=dic.TryGetValue(root.val,out temp);
            if (result)
            {
                dic[root.val]++;
            }
            else
            {
                dic.Add(root.val,1);
            }

            Search(root.left,dic);
            Search(root.right,dic);


        }
    }
}

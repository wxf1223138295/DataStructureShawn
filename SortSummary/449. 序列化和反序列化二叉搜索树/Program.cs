using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _449._序列化和反序列化二叉搜索树
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node=new TreeNode(10);
            node.left=new TreeNode(5);
            node.left.left=new TreeNode(2);
            node.right=new TreeNode(15);
            node.right.left=new TreeNode(11);
            node.right.right=new TreeNode(17);

            Codec c=new Codec();
            var rr=c.serialize(node);
             var re=c.deserialize(rr);
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

    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null)
            {
                return string.Empty;
            }


            StringBuilder builder=new StringBuilder();


            serializecore(builder, root);

            return builder.ToString();
        }
        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="root"></param>
        private void serializecore(StringBuilder builder, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            serializecore(builder, root.left);
            serializecore( builder,root.right);

            builder.Append(root.val+" ");
        }
        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            data = data.Trim();

            var arry = data.Split(" ");

            var node=deserializecore(arry.ToList());

            return node;
        }

        public TreeNode deserializecore(List<string> arry)
        {
            if (arry.Count == 0)
            {
                return null;
            }

            var value=arry.Last();
            var leftarry = new List<string>();
            var rightarry = new List<string>();
            for (int i = 0; i < arry.Count-1; i++)
            {
                if (Convert.ToInt32(arry[i].ToString()) < Convert.ToInt32(value.ToString()))
                {
                    leftarry.Add(arry[i]);
                }
                else
                {
                    rightarry.Add(arry[i]);
                }
            }


            TreeNode node=new TreeNode(Convert.ToInt32(value.ToString()));

            node.left = deserializecore(leftarry);
            node.right = deserializecore(rightarry);

            return node;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec ser = new Codec();
    // Codec deser = new Codec();
    // String tree = ser.serialize(root);
    // TreeNode ans = deser.deserialize(tree);
    // return ans;
}

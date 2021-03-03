using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _297._二叉树的序列化与反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = new TreeNode(10);
            node.left = new TreeNode(5);
            node.left.left = new TreeNode(2);
            node.right = new TreeNode(15);
            node.right.left = new TreeNode(11);
            node.right.right = new TreeNode(17);

            Codec codec=new Codec();
            var txt=codec.serialize(node);
            var re=codec.deserialize(txt);
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
            serializecode(root, builder);

            return builder.ToString();
        }

        private void serializecode(TreeNode root, StringBuilder builder)
        {
            if (root == null)
            {
                builder.Append("NULL ");
               
            }
            else
            {
                serializecode(root.left, builder);
                serializecode(root.right, builder);
                builder.Append(root.val + " ");
            }
           
        }
        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            data = data.Trim();

            var list = data.Split(" ").ToList();

            return deserializecore(list);

        }

        private TreeNode deserializecore(List<string> list)
        {
            if (list.Last() == "NULL")
            {
                list.RemoveAt(list.Count-1);
                return null;
            }

            var value = list.Last();

            TreeNode node=new TreeNode(Convert.ToInt32(value));
            list.RemoveAt(list.Count - 1);
            node.left = deserializecore(list);
            node.right = deserializecore(list);

            return node;

        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec ser = new Codec();
    // Codec deser = new Codec();
    // TreeNode ans = deser.deserialize(ser.serialize(root));
}

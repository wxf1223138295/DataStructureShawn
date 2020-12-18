using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace N_叉树的层序遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1,null,3,2,4,null,5,6]

            Node node = new Node(1);
            node.children = new List<Node>();
            node.children.Add(new Node(3));



            node.children.Add(new Node(2));
            node.children.Add(new Node(4));

            foreach (var nodeChild in node.children)
            {
                if (nodeChild.val == 3)
                {
                    nodeChild.children = new List<Node>();
                    nodeChild.children.Add(new Node(5));
                    nodeChild.children.Add(new Node(6));
                }
            }

            Solution s = new Solution();
            s.LevelOrder(node);
        }
    }
    /*
// Definition for a Node.*/
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }


    public class Solution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> levels = new List<IList<int>>();

            if (root == null)
            {
                return levels;
            }

            //记录每层的节点
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);

            while (nodes.Count > 0)
            {
                int len = nodes.Count;

                //存放这一层的节点值
                List<int> level = new List<int>();

                for (int i = 0; i < len; i++)
                {
                    var currentnode = nodes.Dequeue();

                    level.Add(currentnode.val);


                    if (currentnode.children != null)
                    {
                        foreach (var currentnodeChild in currentnode.children)
                        {
                            if (currentnodeChild != null)
                            {
                                nodes.Enqueue(currentnodeChild);
                            }
                        }
                    }


                }

                levels.Add(level);
            }

            return levels;
        }
    }
}

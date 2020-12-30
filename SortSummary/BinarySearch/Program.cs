using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {


            TreeNode<string> node=new TreeNode<string>("A",new TreeNode<string>("B"   ,new TreeNode<string>("D",
                                                                                                                              new TreeNode<string>("H"),                                                                                          new TreeNode<string>("I")),
                                                                                                     new TreeNode<string>("E",
                                                                                                                             new TreeNode<string>("J"),
                                                                                                                            new TreeNode<string>("K"))),
                                                                
                
                                                               new TreeNode<string>("C",  new TreeNode<string>("F",
                                                                                                                       new TreeNode<string>("L"), 
                                                                                                                       new TreeNode<string>("M")),
                                                                                                    new TreeNode<string>("G",
                                                                                                                         new TreeNode<string>("N"),
                                                                                                                        new TreeNode<string>("O"))));


            //前序遍历
            Console.WriteLine("前序遍历：");
            PreSearch(node);
            Console.WriteLine();
            Console.WriteLine("中序遍历：");
            MidSearch(node);
            Console.WriteLine();
            Console.WriteLine("后序遍历：");
            LastSearch(node);
            Console.ReadKey();

        }

        /// <summary>
        /// 前序
        /// </summary>
        /// <param name="node"></param>
        private static void PreSearch(TreeNode<string> node)
        {
            IList<IList<TreeNode<int>>> sd=new List<IList<TreeNode<int>>>();
            if (node == null)
            {
                return;
            }

            //前序遍历  根  左  右
            Console.Write(node.Data);

            PreSearch(node.LChild);
            PreSearch(node.RChild);
        }
        /// <summary>
        /// 中序
        /// </summary>
        /// <param name="node"></param>
        private static void MidSearch(TreeNode<string> node)
        {
            if (node == null)
            {
                return;
            }

            //中序遍历  左  根   右
            MidSearch(node.LChild);
            Console.Write(node.Data);
            MidSearch(node.RChild);
        }
        /// <summary>
        /// 后序
        /// </summary>
        /// <param name="node"></param>
        private static void LastSearch(TreeNode<string> node)
        {
            if (node == null)
            {
                return;
            }

            //后序遍历  左    右   根  
            LastSearch(node.LChild);
            
            LastSearch(node.RChild);

            Console.Write(node.Data);
        }
    }

    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> LChild { get; set; }
        public TreeNode<T> RChild { get; set; }

        public TreeNode(T data, TreeNode<T> left = null, TreeNode<T> right = null)
        {
            this.Data = data;
            this.LChild = left;
            this.RChild = right;
        }
    }
}

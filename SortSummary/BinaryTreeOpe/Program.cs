using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BinaryTreeOpe
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> re = new Tree<int>(30);


            re.Insert(18);
            re.Insert(20);
            re.Insert(45);
            re.Insert(19);
            re.Insert(7);
            re.Insert(8);
            re.Insert(17);


            PreSearch(re);
            Console.WriteLine("______");
            MidSearch(re);
            Console.WriteLine("______");
            LastSearch(re);
            Console.WriteLine();
            Console.WriteLine("最小值:");
            var min = Min(re);
            Console.Write(min);


        }
        /// <summary>
        /// 后序
        /// </summary>
        /// <param name="node"></param>
        private static void LastSearch(Tree<int> node)
        {
            if (node == null)
            {
                return;
            }

            //中序遍历  左    右   根  
            LastSearch(node.LChild);

            LastSearch(node.RChild);

            Console.Write(node.Data + ",");
        }
        /// <summary>
        /// 中序
        /// </summary>
        /// <param name="node"></param>
        private static void MidSearch(Tree<int> node)
        {
            if (node == null)
            {
                return;
            }

            //中序遍历  左  根   右
            MidSearch(node.LChild);
            Console.Write(node.Data + ",");
            MidSearch(node.RChild);
        }
        /// <summary>
        /// 查找最大值（最右）
        /// </summary>
        /// <returns></returns>
        public static int Max(Tree<int> tree)
        {
            if (tree == null)
            {
                throw new Exception("空二叉树");
            }

            if (tree.RChild == null)
            {
                return tree.Data;
            }


            var maxValue = Min(tree.RChild);

            return maxValue;


        }

        /// <summary>
        /// 查找最小值（最左）
        /// </summary>
        /// <returns></returns>
        public static int Min(Tree<int> tree)
        {
            if (tree == null)
            {
                throw new Exception("空二叉树");
            }

            if (tree.LChild == null)
            {
                return tree.Data;
            }


            var minValue = Min(tree.LChild);

            return minValue;


        }
        /// <summary>
        /// 前序
        /// </summary>
        /// <param name="node"></param>
        private static void PreSearch(Tree<int> node)
        {
            if (node == null)
            {
                return;
            }

            //前序遍历  根  左  右
            Console.Write(node.Data + ",");

            PreSearch(node.LChild);
            PreSearch(node.RChild);
        }
    }

    //public class ShawnKey:IComparable
    //{
    //    public int CompareTo(object? obj)
    //    {

    //    }
    //}

    public class Tree<T> where T : IComparable<T>
//继承的这个接口用于通用比较
    {
        public T Data { get; set; }
        public Tree<T> LChild { get; set; }
        public Tree<T> RChild { get; set; }

        public Tree(T data, Tree<T> left = null, Tree<T> right = null)
        {
            this.Data = data;
            this.LChild = left;
            this.RChild = right;
        }
        /// <summary>
        /// 各节点 唯一
        /// </summary>
        /// <param name="Item"></param>
        //public Tree<int> Remove(Tree<int> tree,[NotNull] T Item)
        //{
        //    if (tree == null)
        //    {
        //        return null;

        //    }



        //    int currentNodeValue = tree.Data;
        //    //>0 大于item  =0 相等  <0 小于
        //    var compareResult = currentNodeValue.CompareTo(Item);

        //    if (compareResult > 0)
        //    {
        //        tree.LChild = Remove(tree.LChild, Item);
        //    }

        //    else if (compareResult < 0)
        //    {
        //        tree.RChild = Remove(tree.RChild, Item);
        //    }
        //    else
        //    {
        //        if()
        //    }

        //}



        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="Item"></param>
        public void Insert(T Item)
        {
            T currentNodeValue = this.Data;
            //>0 大于item  =0 相等  <0 小于
            var compareResult = currentNodeValue.CompareTo(Item);



            //比根节点小就放左节点
            if (compareResult > 0)
            {
                if (this.LChild == null)
                {
                    this.LChild = new Tree<T>(Item);
                }

                else
                {
                    this.LChild.Insert(Item);
                }
            }
            //比根节点大 右边
            else if (compareResult < 0)
            {
                if (this.RChild == null)
                {
                    this.RChild = new Tree<T>(Item);
                }
                else
                {
                    this.RChild.Insert(Item);
                }
            }
            else
            {
                return;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _437._路径总和_III
{
    class Program
    {
        public static volatile int sum = 0;
        //public static volatile int i = 0;
        static void Main(string[] args)
        {

            // new Thread(() =>
            // {
            //     while (i<=100)
            //     {
            //         if (i % 2 == 0)
            //         {
            //             Console.WriteLine($"{i}:当前线程{Thread.CurrentThread.ManagedThreadId}");
            //             i = i+1;
            //             Thread.Sleep(100);
            //         }
            //     }

            // }).Start();

            //new Thread(() =>
            // {
            //     while (i <100)
            //     {

            //         if (i % 2==1)
            //         {
            //             Console.WriteLine($"{i}:当前线程{Thread.CurrentThread.ManagedThreadId}");
            //             i = i + 1;
            //             Thread.Sleep(100);
            //         }
            //     }


            // }).Start();

            for (int i = 0; i < 100; i++)
            {
                SumResut();
                Console.WriteLine(sum);
                sum = 0;
            }
            
            Console.ReadKey();
        }

        private static void SumResut()
        {

            Parallel.For(0, 10, (a) =>
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = sum + 1;
                }

            });

            Thread.Sleep(1000);

        }
    }
    /**
 * Definition for a binary tree node.*/
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        //public int PathSum(TreeNode root, int sum)
        //{
            
        //}

        
        private int count = 0;
        List<int> listsum=new List<int>();
        private void PathSumCore(TreeNode root,int sum)
        {
            //到达叶子节点
            if (root == null)
            {
                //判断list存在和为sum的值
                return;
            }
            listsum.Add(root.val);

            if (root.left != null)
            {
                PathSumCore(root.left, sum);
                listsum.RemoveAt(listsum.Count-1);
            }

            if (root.right != null)
            {
                PathSumCore(root.right, sum);
                listsum.RemoveAt(listsum.Count - 1);
            }
          
        }

        //private bool IsExsit(List<int> list,int sum)
        //{
        //    int rightindex = 0;

        //    for (int i = 0; i < list.Count; i++)
        //    {
                
        //    }
        //}
    }
}

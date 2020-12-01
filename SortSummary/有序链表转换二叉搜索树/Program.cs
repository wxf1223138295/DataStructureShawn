using System;
using LinkedListDef;

namespace 有序链表转换二叉搜索树
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // Definition for a binary tree node.
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
        public TreeNode SortedListToBST(SingleListNode head)
        {
           return BuildTree(head, null);
        }
        /// <summary>
        /// 1.用双指针 做快慢指针 找中间节点
        /// 2.中序构建 bst
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public TreeNode BuildTree(SingleListNode left,SingleListNode right)
        {
            //中序构建

            if (left == right)
            {
                return null;
            }

            var mid = FindMidNode(left, right);
            //构建 左节点
            var leftnode = BuildTree(left,mid);


            //构建 根节点

            var rootnode = new TreeNode(mid.val);

            //构建 右节点

            var rightnode = BuildTree(mid.next, right);

            rootnode.left = leftnode;
            rootnode.right = rightnode;

            return rootnode;
        }


        public SingleListNode FindMidNode(SingleListNode left, SingleListNode right)
        {
            SingleListNode fast = left;
            SingleListNode slow = left;
            while (fast != right && fast.next != right)
            {
                fast = fast.next;
                fast = fast.next;
                slow = slow.next;
            }
            return slow;

        }
    }
}

using System;
using LinkedListDef;

namespace 删除中间节点
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s=new Solution();

            //s.deleteNode();
        }
    }

    class Solution
    {
        public void deleteNode(SingleListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }

}

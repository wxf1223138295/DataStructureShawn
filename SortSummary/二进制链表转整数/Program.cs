using System;
using System.Text;
using LinkedListDef;

namespace 二进制链表转整数
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution=new Solution();

            SingleListNode node=new SingleListNode(1);
            node.next=new SingleListNode(0);
            node.next.next=new SingleListNode(1);
            solution.GetDecimalValue(node);
        }
    }

    public class Solution
    {
        public int GetDecimalValue(SingleListNode head)
        {
            StringBuilder sb=new StringBuilder(head.val.ToString());

            while (true)
            {
                if (head.next == null)
                {
                    break;
                }
                sb.Append(head.next.val);

                

                head = head.next;
            }

            string strvalue = sb.ToString();

            return Convert.ToInt32(strvalue, 2);
        }
    }
}

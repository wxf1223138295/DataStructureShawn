using System;
using System.Net.Http.Headers;

namespace _61._旋转链表
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);


            //node.next = new ListNode(2);

            //node.next.next = new ListNode(3);

            //node.next.next.next = new ListNode(4);
            //node.next.next.next.next = new ListNode(5);
            Solution s=new Solution();
            var result=s.RotateRight(node, 1);
            Console.WriteLine("Hello World!");
        }
    }
    /**
 * Definition for singly-linked list. */
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }

    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0)
            {
                return head;
            }
            if (head == null)
            {
                return head;
            }
          
            //获取长度
            int count = 0;
           


            var temp = head;
            var counttemp = head;
            while (counttemp != null)
            {
                count++;
                counttemp = counttemp.next;
            }

            var len = k % count;

            ListNode node = null;
            for (int i = 0; i < len; i++)
            {

                var next = temp;

                var temphead = temp;

              
                while (temphead.next != null)
                {
                    if (temphead.next.next == null)
                    {
                        node = temphead.next;
                        temphead.next = null;
                        break;
                    }
                    temphead = temphead.next;
                }

                if (node != null)
                {
                    node.next = next;
                    temp = node;
                }
           
               
            }

            return temp;
        }

        
    }
}

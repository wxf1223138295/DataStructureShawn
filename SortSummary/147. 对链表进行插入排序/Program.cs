using System;
using System.Threading;

namespace _147._对链表进行插入排序
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
        }
    }

    /**
 * Definition for singly-linked list. */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            var current = head.next;

            //相当于数组从索引1循环
            while (current!=null)
            {
                

            }
        }

        public void InsertSortArry(int[] myArray)
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                var preindex = i - 1;
                var currentvalue = myArray[i];

                while (preindex >= 0 && myArray[preindex] > currentvalue)
                {
                    myArray[preindex + 1] = myArray[preindex];
                    preindex--;
                }
                myArray[preindex + 1] = currentvalue;

            }
        }
    }
}

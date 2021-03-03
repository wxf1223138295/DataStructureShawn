using System;
using System.Collections.Generic;
using System.Threading;

namespace 环形链表
{
    public class Test
    {
        public int iscan = 0;

        public void Enter()
        {
            while (Interlocked.Exchange(ref iscan,1)!=0)
            {
              //  Interlocked.

              
            }
        }

        public void Cancle()
        {
            Interlocked.Exchange(ref iscan, 0);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Test t=new Test();
            List<int> list=new List<int>();
            int i = 0;
            new Thread(() =>
            {
                while (i <= 100)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i}:当前线程{Thread.CurrentThread.ManagedThreadId}");
                        t.Enter();
                        i = i + 1;
                        t.Cancle();
                        Thread.Sleep(100);
                    }
                }
              
            }).Start();

            new Thread(() =>
            {
                while (i <100)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine($"{i}:当前线程{Thread.CurrentThread.ManagedThreadId}");
                        t.Enter();
                        i = i + 1;
                        t.Cancle();
                        Thread.Sleep(100);
                    }
                }

            }).Start();



            Console.WriteLine("Hello World!");
        }
    }
    /**
 * Definition for singly-linked list.*/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null||head.next==null)
            {
                return false;
            }
            var fastpoint = head;
            var slowpoint = head;

            while (fastpoint != null && fastpoint.next != null)
            {
                fastpoint = fastpoint.next.next;
                slowpoint = slowpoint.next;
                if (slowpoint == fastpoint)
                {
                    break;
                }

            }

            if (fastpoint != slowpoint)
            {
                return false;
            }

            fastpoint = head;
            while (fastpoint != slowpoint)
            {
                fastpoint = fastpoint.next;
                slowpoint = slowpoint.next;
            }

            return true;

        }
    }


}

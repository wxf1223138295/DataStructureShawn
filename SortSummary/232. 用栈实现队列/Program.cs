using System;
using System.Collections;

namespace _232._用栈实现队列
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MyQueue
    {
        public Stack stack1;
        public Stack stack2;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            stack1 = new Stack();
            stack2 = new Stack();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            while (!Empty())
            {
                var temp = stack1.Pop();

                stack2.Push(temp);
            }

            var value = (int)stack2.Pop();

            while(stack2.Count>0)
            {
                var temp2 = stack2.Pop();
                stack1.Push(temp2);
            }

            return value;
        }

        /** Get the front element. */
        public int Peek()
        {
            while (!Empty())
            {
                var temp = stack1.Pop();

                stack2.Push(temp);
            }

            var value = (int)stack2.Peek();

            while (stack2.Count > 0)
            {
                var temp2 = stack2.Pop();
                stack1.Push(temp2);
            }

            return value;
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stack1.Count <= 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}

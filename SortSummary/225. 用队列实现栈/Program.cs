using System;
using System.Collections;

namespace _225._用队列实现栈
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            stack.Push(1);
            stack.Push(2);
            stack.Top();
            stack.Pop();
            var rr = stack.Empty();
        }
    }

    public class MyStack
    {
        public Queue queue;
        /** Initialize your data structure here. */
        public MyStack()
        {
            queue = new Queue();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            queue.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            var count = queue.Count;

            int result = 0;

            for (int i = 0; i < count; i++)
            {

                var temp=queue.Dequeue();

                if (i == count - 1)
                {
                    result = (int)temp;
                    break;
                }
                else
                {
                    queue.Enqueue(temp);
                }
            }

            var count1 = queue.Count;

            for (int i = 0; i < count1; i++)
            {
                var temp = queue.Dequeue();

                queue.Enqueue(temp);
            }

            return result;
        }

        /** Get the top element. */
        public int Top()
        {
            var count = queue.Count;

            int result = 0;

            for (int i = 0; i < count; i++)
            {

                var temp = queue.Dequeue();

                if (i == count - 1)
                {
                    result = (int)temp;
          
                }
                queue.Enqueue(temp);

            }

            var count1 = queue.Count;

            for (int i = 0; i < count1; i++)
            {
                var temp = queue.Dequeue();

                queue.Enqueue(temp);
            }
            return result;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return queue.Count <= 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}

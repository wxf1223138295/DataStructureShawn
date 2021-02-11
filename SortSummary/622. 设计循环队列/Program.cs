using System;

namespace _622._设计循环队列
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Node
    {
        public int value;
        public Node nextNode;

        public Node(int value)
        {
            this.value = value;
            this.nextNode = null;
        }
    }
    /**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
    public class MyCircularQueue
    {
        public Node head;
        public Node tail;
        public int capacity;
        private int count;

        public MyCircularQueue(int k)
        {
            capacity = k;
        }

        public bool EnQueue(int value)
        {
            if (capacity == count)
            {
                return false;
            }

            Node n=new Node(value);

            if (count == 0)
            {
                head = tail = n;
            }
            else
            {
                tail.nextNode = n;
                tail = n;
            }

            this.count += 1;
            return true;
        }

        public bool DeQueue()
        {
            if (this.count == 0)
                return false;
            this.head = this.head.nextNode;
            this.count -= 1;
            return true;
        }

        public int Front()
        {
            if (count == 0)
            {
                return -1;
            }
            else
            {
                return head.value;
            }

        }

        public int Rear()
        {
            if (count == 0)
            {
                return -1;
            }
            else
            {
                return tail.value;
            }

        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == capacity;
        }
    }
}

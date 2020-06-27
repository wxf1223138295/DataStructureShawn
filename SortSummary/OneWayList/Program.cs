using System;

namespace OneWayList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> list=new LinkList<int>();
            list.Append(1);
            list.Append(2);
            Console.ReadKey();
        }
    }

    public class Node<T>
    {
        private T data;
        private Node<T> next;
        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }

        public Node(Node<T> p)
        {
            next = p;
        }

        public Node(T val)
        {
            data = val;
            next = null;
        }


        public Node()
        {
            data = default(T);
            next = null;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }

    public class LinkList<T>
    {
        private Node<T> head;

        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        public LinkList()
        {
            head = null;
        }
        public void Append(T item)
        {
            Node<T> d = new Node<T>(item);
            Node<T> n = new Node<T>();

            if (head == null)
            {
                head = d;
                return;
            }

            n = head;
            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = d;
        }
        /// <summary>
        /// 返回单链表的长度
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                len++;
                p = p.Next;
            }
            return len;
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }
        /// <summary>
        /// 在位置i后插入元素item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i"></param>
        public void InsertAfter(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }

            if (i == 0)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }

            Node<T> p = head;
            int j = 0;

            while (p != null && j < i)
            {
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
            else
            {
                Console.WriteLine("Position is error!");
            }
        }

        /// <summary>
        /// 删除位置i的元素
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T RemoveAt(int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("Link is empty or Position is error!");
                return default(T);
            }

            Node<T> q = new Node<T>();
            if (i == 0)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }

            Node<T> p = head;
            int j = 0;

            while (p.Next != null && j < i)
            {
                j++;
                q = p;
                p = p.Next;
            }

            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The node is not exist!");
                return default(T);
            }
        }
    }
}

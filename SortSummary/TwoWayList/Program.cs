using System;

namespace TwoWayList
{
    class Program
    {
        static void Main(string[] args)
        {
            DbLinkedList<int> list=new DbLinkedList<int>();
            list.Append(1);
            list.Append(2);

            Console.ReadKey();
        }
    }

    public class DbLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public DbLinkedList()
        {
            Head = null;
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                return this.GetItemAt(index);
            }
        }
        /// <summary>
        /// 在位置i后插入node T
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i"></param>
        public void AddAfter(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("The double linked list is empty or the position is uncorrect.");
                return;
            }


            if (0 == i) //在头之后插入元素
            {
                Node<T> newNode = new Node<T>(item);
                newNode.Next = Head.Next;
                Head.Next.Pre = newNode;
                Head.Next = newNode;
                newNode.Pre = Head;
                return;
            }

            Node<T> p = Head; //p指向head
            int j = 0;

            while (p != null && j < i)
            {
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                Node<T> newNode = new Node<T>(item);
                newNode.Next = p.Next;
                p.Next = newNode;
                if (p.Next != null)
                {
                    p.Next.Pre = newNode;
                }
                newNode.Pre = p;
            }
            else
            {
                Console.WriteLine("The position is uncorrect.");
            }



        }

        /// <summary>
        /// 获取指定位置的元素
        /// </summary>
        /// <param name="i">指定的位置</param>
        /// <returns>T node</returns>
        public T GetItemAt(int i)
        {
            //判空
            if (IsEmpty())
            {
                Console.WriteLine("The double linked list is empty.");
                return default(T);
            }
          
            Node<T> p = new Node<T>();
            p = Head;
            // 如果是第一个node
            if (0 == i)
            {
                return p.Data;
            }
            int j = 0;
            while (p.Next != null&&j < i)
            {
                p = p.Next;
                j++;
            }

            if (j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("The node dose not exist.");
                return default(T);
            }

        }
        /// <summary>
        /// 判断双向链表是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Append(T item)
        {
            Node<T> newNode = new Node<T>(item);

            Node<T> p = new Node<T>();

            if (Head == null)
            {
                this.Head = newNode;
                return;
            }

            p = Head;

            while (p.Next!=null)
            {
                p = p.Next;
            }
            //直到next是null
            p.Next = newNode;
            newNode.Pre = p;
        }
    }
    public class Node<T>
    {
        private T data;
        private Node<T> next;
        private Node<T> pre;
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
            pre = null;
        }


        public Node()
        {
            data = default(T);
            next = null;
            pre = null;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Pre
        {
            get { return pre; }
            set { pre = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDef
{
    public class SingleListNode
    {
        public int val;
        public SingleListNode next;

        public SingleListNode(int x)
        {
            val = x;
        }

        public SingleListNode(int val = 0, SingleListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

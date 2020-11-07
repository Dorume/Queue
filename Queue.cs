using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        private Node head, tail;
        public int Size { get; set; }

        public int Push(int number)
        {
            Node node = new Node(number);
            if(IsEmpty())
            {
                head = node;
                tail = node;
                head.Next = tail;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            Size++;
            return node.Data;
        }

        public int Pop()
        {
            Node node = head;
            head = head.Next;
            Size--;
            return node.Data;
        }

        public void Clear()
        {
            while (Size > 0)
                Pop();
        }

        public int Front() => head.Data;
        public bool IsEmpty() => Size == 0;
    }
}

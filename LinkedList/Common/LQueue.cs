using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Common
{
    public class LQueue
    {
        public Node Head = null;
        public Node Temp = null;

        public Node CreateNode(int val)
        {
            return new Node(val);
        }

        public void Enqueue(int val)
        {
            Node temp = null;
            if(Head==null)
            {
                Head = Head = CreateNode(val);
                temp = Head;
            }
            else
            {
                temp.Next = CreateNode(val);
                temp = temp.Next;

            }

        }

        public int Dequeue()
        {
            if (Head == null) return -1;
            var retval = Head.Val;
            Head = Head.Next;
            return retval;
        }
    }
}

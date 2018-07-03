using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Common
{
    public class LStack
    {
        public Node Head = null;

        public Node CreateNode(int val)
        {
            return new Node(val);
        }

        public void Push(int val)
        {
            if (Head == null)
            {
                Head = CreateNode(val);
            }
            else
            {
                Node n = CreateNode(val);
                n.Next = Head;
                Head = n;
            }
        }

        public int Pop()
        {
            if (Head == null) return -1;
            var retval = Head.Val;
            Head = Head.Next;
            return retval;
        }

     
    }
}

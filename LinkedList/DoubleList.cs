using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoubleList
    {

        public DoubleNode Head = null;
    

        public Node CreateNode(int val)
        {
            return new Node(val);
        }

        public void InsertNode(int val)
        {
            DoubleNode n = new DoubleNode(val);
            n.Next = Head;
            n.Prev = null;

            if(Head!=null)
            {
                Head.Prev = n;
            }

            Head = n;
        }

    }
}

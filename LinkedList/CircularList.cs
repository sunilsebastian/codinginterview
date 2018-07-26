using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public  class CircularList
    {
        public Node Head = null;
        public Node temp = null;
        public Node LoopBackNode = null;
        public int loopBackValue;

        public Node CreateNode(int val)
        {
            return new Node(val);
        }

        public void SetLoopBack()
        {
            temp.Next = LoopBackNode;

        }

        public void SetLoopBackVal(int loopBackVal)
        {
            loopBackValue = loopBackVal;
        }

        public void Insert(int val)
        {
            if (Head == null)
            {
                Head = Head = CreateNode(val);
                temp = Head;
                if(Head.Val==loopBackValue)
                {
                    LoopBackNode = Head;
                }
            }
            else
            {
                temp.Next = CreateNode(val);
                temp = temp.Next;
                if (temp.Val == loopBackValue)
                {
                    LoopBackNode = temp;
                }

            }

        }
    }
}

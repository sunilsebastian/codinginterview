using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class FlatternDoubleList
    {
        public DoubleNode Flatten(DoubleNode head)
        {

            if (head == null)
                return null;
            FlatternHealper(head);
            return head;
        }

        public DoubleNode FlatternHealper(DoubleNode head)
        {
            DoubleNode current = head;
            DoubleNode tail = head;

            while (current != null)
            {
                DoubleNode nextPtr = current.Next;
                DoubleNode childPtr = current.Child;
                if(childPtr != null)
                {
                    //returns the last DoubleNode
                    DoubleNode _tail = FlatternHealper(childPtr);

                    _tail.Next = nextPtr;
                    if (nextPtr != null)
                        nextPtr.Prev = _tail;
                    current.Next = childPtr;
                    childPtr.Prev = current;
                    current.Child = null;

                    //current jump to the tail
                    current = tail;
                }
                else
                    current = current.Next;

                //current become null so tale will be the last node
                if (current != null)
                    tail = current;
            }

            return tail;
        }
    }
}

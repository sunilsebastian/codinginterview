using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public  class OddEvenLinkedList
    {
        public static  Node GetOddEvenList(Node head)
        {
            if (head == null)
                return head;

            Node result = head;
            Node current = head;
            Node nextPtr = head.Next;
            Node connectNode = head.Next;

            while (current != null && nextPtr != null)
            {
                Node t = nextPtr.Next;
                if (t == null)
                    break;

                current.Next = nextPtr.Next;
                current = current.Next;

                nextPtr.Next = current.Next;
                nextPtr = nextPtr.Next;
            }

            current.Next = connectNode;

            return result;
        }
    }
}

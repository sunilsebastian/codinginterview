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
            Node p1 = head;
            Node p2 = head.Next;
            Node connectNode = head.Next;

            while (p1 != null && p2 != null)
            {
                Node t = p2.Next;
                if (t == null)
                    break;

                p1.Next = p2.Next;
                p1 = p1.Next;

                p2.Next = p1.Next;
                p2 = p2.Next;
            }

            p1.Next = connectNode;

            return result;
        }
    }
}

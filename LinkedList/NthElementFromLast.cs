using LinkedList.Common;
using System;

namespace LinkedList
{
    public class NthElementFromLast
    {
        public static Node FindNthElementFromLast(Node head, int n)
        {
            Node current = head;
            Node start = head;

            for (int i = 0; i < n; i++)
            {
                if (current != null)
                {
                    current = current.Next;
                }
            }
            if (current == null)
            {
                throw new Exception("Nummber of elements are less than N");
            }

            while (current != null)
            {
                start = start.Next;
                current = current.Next;
            }

            return start;
        }
    }
}
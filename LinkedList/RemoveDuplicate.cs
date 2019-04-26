using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class RemoveDuplicate
    {
        public Node DeleteDuplicates(Node head)
        {
            if (head == null || head.Next == null)
                return head;

            Node prev = head;
            Node p = head.Next;

            while (p != null)
            {
                if (p.Val == prev.Val)
                {
                    prev.Next = p.Next;
                    p = p.Next;
                    //no change prev
                }
                else
                {
                    prev = p;
                    p = p.Next;
                }
            }

            return head;
        }
    }
}

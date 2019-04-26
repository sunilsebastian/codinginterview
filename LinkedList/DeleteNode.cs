using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteNode
    {
        public static void Delete(Node head,int key)
        {
            Node temp = head, prev = null;

            if (temp != null && temp.Val == key)
            {
                head = temp.Next;
                return;
            }

            while (temp != null && temp.Val != key)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null) return;

            prev.Next = temp.Next;
        }
    }
}

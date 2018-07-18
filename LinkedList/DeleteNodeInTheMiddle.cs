using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DeleteNodeInTheMiddle
    {

        public static Node  DeleteMiddleNode(Node head)
        {
      
            Node fast = head;
            Node slow = head;
            Node prev = null;

            while (slow!=null && fast.Next!=null)
            {
                prev = slow;
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            prev.Next = slow.Next;


            return head;

        }
    }
}

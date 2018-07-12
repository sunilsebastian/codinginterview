using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public  class AlternativeKNodes
    {
        public static Node ReverseAlterNativeKNodes(Node head, int k)
        {
            Node prev = null;
            Node current = head;
            Node NextPtr;
            int count = 0;


            while (current != null && count < k)
            {
                NextPtr = current.Next;
                current.Next = prev;
                prev = current;
                current = NextPtr;
                count++;
            }


            if (head != null)
            {

                head.Next = current;
            }



            int cnt = 0;
            while (cnt < k - 1 && current != null)
            {
                current = current.Next;
                cnt++;
            }

            if (current != null)
                current.Next = ReverseAlterNativeKNodes(current.Next, k);

            return prev;
        }
    }
}

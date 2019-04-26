using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CloneListWithRandomPtr
    {
        public static RandomNode CopyRandomList(RandomNode head)
        {
            RandomNode current = head;

          
            while (current != null)
            {
                RandomNode clone = new RandomNode(current.val, null, null);
                clone.next = current.next;
                current.next = clone;
                current = clone.next;
            }
            current = head;
            while(current!=null)
            {
                current.next.random = current.random.next;
                current = current.next.next;

            }
            current = head;
            RandomNode newHead = head.next;
            while (current != null)
            {
                RandomNode temp = current.next;

                current.next = temp.next;
                if (temp.next != null)
                {
                    temp.next = temp.next.next;
                }
                current = current.next;
            }
            return newHead;
        }
    }
}

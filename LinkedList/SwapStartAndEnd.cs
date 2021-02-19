using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SwapStartAndEnd
    {

        public static  Node SwapNodes(Node head, int k)
        {

            if (head == null)
                return null;

            Node startK = head;
            int i = 0;
            while (i < k - 1 && startK != null)
            {
                startK = startK.Next;
                i++;
            }

            int j = 0;
            Node start1 = head;
            Node endK = head;
            while (j < k && start1 != null)
            {
                start1 = start1.Next;
                j++;
            }
            while (start1 != null)
            {
                start1 = start1.Next;
                endK = endK.Next;
            }

            if (startK != null && endK != null)
            {
                int temp = startK.Val;
                startK.Val = endK.Val;
                endK.Val = temp;
            }


            return head;
        }
    }
}

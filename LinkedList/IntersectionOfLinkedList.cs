using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class IntersectionOfLinkedList
    {
        public static Node getIntersectionNode(Node headA, Node headB)
        {
            int len1 = 0;
            int len2 = 0;
            Node p1 = headA, p2 = headB;
            if (p1 == null || p2 == null)
                return null;

            while (p1 != null)
            {
                len1++;
                p1 = p1.Next;
            }
            while (p2 != null)
            {
                len2++;
                p2 = p2.Next;
            }

            int diff = 0;
            p1 = headA;
            p2 = headB;

            if (len1 > len2)
            {
                diff = len1 - len2;
                int i = 0;
                while (i < diff)
                {
                    p1 = p1.Next;
                    i++;
                }
            }
            else
            {
                diff = len2 - len1;
                int i = 0;
                while (i < diff)
                {
                    p2 = p2.Next;
                    i++;
                }
            }

            while (p1 != null && p2 != null)
            {
                if (p1.Val == p2.Val)
                {
                    return p1;
                }
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return null;
        }
    }
}

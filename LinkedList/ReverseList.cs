using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ReverseList
    {
        public static Node Reverse(Node head)
        {
            Node Prev = null;
            Node Current = head;

            while(Current!=null)
            {
                Node NextPtr = Current.Next;
                Current.Next = Prev;
                Prev = Current;
                Current = NextPtr;


            }

            return Prev;

        }
    }
}

using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ReverseRecursively
    {

        public static Node Reverse(Node Current,Node Prev=null)
        {
            Node NextPtr = Current.Next;
            Current.Next = Prev;
            return (NextPtr == null) ? Current : Reverse(NextPtr, Current);

        }


    }
}

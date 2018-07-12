using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SortBasedOnAbsoluteValue
    {
        public Node Sort(Node Head)
        {
            //1 2 3 -4 -5

            Node Prev = Head;

            Node Current = Head.Next;

            while (Current != null)
            {
                if (Current.Val < Prev.Val)
                {
                    Prev.Next = Current.Next;
                    Current.Next = Head;
                    Head = Current;
                    Current = Prev;
                }
                else
                {
                    Prev = Prev.Next;
                }

                Current = Current.Next;
            }

            return Head;
        }
    }
}

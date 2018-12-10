using LinkedList.Common;

namespace LinkedList
{
    public class ReverseRecursively
    {
        public static Node Reverse(Node Current, Node Prev = null)
        {
            if (Current == null)
                return Prev;
            Node NextPtr = Current.Next;
            Current.Next = Prev;
           return Reverse(NextPtr, Current);
            //return (NextPtr == null) ? Current : Reverse(NextPtr, Current);
        }
    }
}
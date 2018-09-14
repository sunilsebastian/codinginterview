using LinkedList.Common;

namespace LinkedList
{
    public class ReverseList
    {
        public static Node Reverse(Node head)
        {
            Node Prev = null;
            Node Current = head;

            while (Current != null)
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
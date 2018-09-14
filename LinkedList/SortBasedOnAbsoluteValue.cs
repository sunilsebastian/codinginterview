using LinkedList.Common;

namespace LinkedList
{
    public class SortBasedOnAbsoluteValue
    {
        public static Node Sort(Node Head)
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

        public static Node Sort1(Node head)
        {
            //1 2 3 -4 -5

            Node Current = head.Next;
            Node Prev = head;
            while (Current != null)
            {
                if (Current.Val < Prev.Val)
                {
                    Prev.Next = Current.Next;
                    Current.Next = head;
                    head = Current;
                    Current = Prev;
                }

                Prev = Current;
                Current = Current.Next;
            }
            return head;
        }
    }
}
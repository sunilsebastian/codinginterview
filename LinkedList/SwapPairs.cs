using LinkedList.Common;

namespace LinkedList
{
    public class SwapPairs
    {
        public static Node SwapNodes(Node head)
        {
            if (head == null)
                return null;

            Node Prev = null;
            Node current = head;
            Node runner = current.Next;

            while (current != null && runner != null)
            {
                current.Next = runner.Next;
                runner.Next = current;

                if (Prev == null)
                {
                    Prev = current;
                    head = runner;
                }
                else
                {
                    Prev.Next = runner;
                    Prev = Prev.Next.Next;
                }

                current = current.Next;
                if (current == null)
                    break;
                runner = runner.Next.Next.Next;
            }

            return head;
        }
    }
}
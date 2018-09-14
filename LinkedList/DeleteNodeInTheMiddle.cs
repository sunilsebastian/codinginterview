using LinkedList.Common;

namespace LinkedList
{
    public class DeleteNodeInTheMiddle
    {
        public static Node DeleteMiddleNode(Node head)
        {
            Node fast = head;
            Node slow = head;
            Node prev = null;

            while (fast != null && fast.Next != null)
            {
                prev = slow;
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            prev.Next = slow.Next;

            return head;
        }
    }
}
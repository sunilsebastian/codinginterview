using LinkedList.Common;

namespace LinkedList
{
    public class CircularList
    {
        public Node Head = null;
        public Node temp = null;
        public Node LoopBackNode = null;
        public int loopBackValue;

        public Node CreateNode(int val)
        {
            return new Node(val);
        }

        public void SetLoopBack()
        {
            temp.Next = LoopBackNode;
        }

        public void SetLoopBackVal(int loopBackVal)
        {
            loopBackValue = loopBackVal;
        }

        public void Insert(int val)
        {
            if (Head == null)
            {
                Head = CreateNode(val);
                temp = Head;
                if (Head.Val == loopBackValue)
                {
                    LoopBackNode = Head;
                }
            }
            else
            {
                temp.Next = CreateNode(val);
                temp = temp.Next;
                if (temp.Val == loopBackValue)
                {
                    LoopBackNode = temp;
                }
            }
        }

        public bool IsCircularListHasCollition()
        {
            bool isCollition = false;

            Node start = Head;

            Node fast = Head;
            Node slow = Head;

            while (slow != null && fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    isCollition = true;
                    break;
                }
            }
            return isCollition;
        }

        public Node GetCollitionNode()
        {
            bool isCollition = false;

            Node start = Head;

            Node fast = Head;
            Node slow = Head;

            while (slow != null && fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    isCollition = true;
                    break;
                }
            }
            if (isCollition == true)
            {
                while (start != slow)
                {
                    start = start.Next;
                    slow = slow.Next;
                }
            }

            return start;
        }
    }
}
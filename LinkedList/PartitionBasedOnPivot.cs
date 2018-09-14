using LinkedList.Common;

namespace LinkedList
{
    public class PartitionBasedOnPivot
    {
        // 1->3->2->9->4-7-11-5
        //  4> right
        // <=4 left.

        public static Node Partition(Node head, int pivot)
        {
            Node Start = head;
            Node FirstNodeStart = null;
            Node FirstNodeEnd = null;
            Node SecondNodeStart = null;
            Node SecondNodeEnd = null;

            if (Start == null)
                return null;

            while (Start != null)
            {
                if (Start.Val <= 4)
                {
                    if (FirstNodeStart == null)
                    {
                        FirstNodeStart = Start;
                    }
                    else
                    {
                        FirstNodeEnd.Next = Start;
                    }
                    FirstNodeEnd = Start;
                }
                if (Start.Val > 4)
                {
                    if (SecondNodeStart == null)
                    {
                        SecondNodeStart = Start;
                    }
                    else
                    {
                        SecondNodeEnd.Next = Start;
                    }
                    SecondNodeEnd = Start;
                }

                Start = Start.Next;
            }

            if (FirstNodeEnd != null)
            {
                FirstNodeEnd.Next = SecondNodeStart;
                return FirstNodeStart;
            }
            else
            {
                return SecondNodeStart;
            }
        }
    }
}
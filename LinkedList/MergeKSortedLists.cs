using LinkedList.Common;

namespace LinkedList
{
    public class MergeKSortedLists
    {
        public static Node Merge(Node n1, Node n2)
        {
            Node Dummy = new Node(0);
            Node Result = Dummy;

            while (n1 != null && n2 != null)
            {
                if (n1.Val <= n2.Val)
                {
                    Result.Next = n1;
                    n1 = n1.Next;
                }
                else
                {
                    Result.Next = n2;
                    n2 = n2.Next;
                }
                Result = Result.Next;
            }
            if (n1 == null) Result.Next = n2;
            if (n2 == null) Result.Next = n1;

            return Dummy.Next;
        }

        public static Node MergeRecursive(Node n1, Node n2)
        {
            if (n1 == null) return n2;
            if (n2 == null) return n1;

            if (n1.Val <= n2.Val)
            {
                n1.Next = MergeRecursive(n1.Next, n2);
                return n1;
            }
            else
            {
                n2.Next = MergeRecursive(n1, n2.Next);
                return n2;
            }
        }
    }
}
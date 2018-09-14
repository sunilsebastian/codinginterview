using System.Collections.Generic;
using System.Linq;

namespace LinkedList
{
    //Program an Iterator for a Linked List which may include nodes  whih are nested within other nodes.

    /*1-->2-->3-->4
      |
      6-->7-->10
         |     |
         8-->9 11-->12  */

    public class ListIterator
    {
        private MyNode head;
        private Stack<MyNode> stack = new Stack<MyNode>();

        public ListIterator()
        {
            head = new MyNode(1);
            head.Next = new MyNode(2);
            head.Next.Next = new MyNode(3);
            head.Next.Next.Next = new MyNode(4);

            head.Down = new MyNode(6);
            head.Down.Next = new MyNode(7);

            head.Down.Next.Next = new MyNode(10);
            head.Down.Next.Down = new MyNode(8);
            head.Down.Next.Down.Next = new MyNode(9);
            head.Down.Next.Next.Down = new MyNode(11);
            head.Down.Next.Next.Down.Next = new MyNode(12);

            stack.Push(head);
        }

        public bool HasAny()
        {
            if (stack.Any())
            {
                return true;
            }
            return false;
        }

        public int Next()
        {
            var n = stack.Pop();
            if (n.Next != null)
            {
                stack.Push(n.Next);
            }
            if (n.Down != null)
            {
                stack.Push(n.Down);
            }
            return n.Val;
        }
    }

    public class MyNode
    {
        public int Val { get; set; }
        public MyNode Next { get; set; }
        public MyNode Down { get; set; }

        public MyNode(int val)
        {
            this.Val = val;
        }
    }
}
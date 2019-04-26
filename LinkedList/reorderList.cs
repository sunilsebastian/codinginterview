using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ReorderList
    {

        public static void GetReorderList(Node head)
        {
            Node slow = head;
            Node fast = head;
            Stack<Node> stk = new Stack<Node>();
            Node root = null;
            while (fast != null && fast.Next != null)
            {
                stk.Push(slow);
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            if (fast != null)
            {
                root = slow;
                slow = slow.Next;
                root.Next = null;
            }

            while (stk.Count != 0 && slow != null)
            {
                Node n = stk.Pop();
                Node NextPtr = slow.Next;
                slow.Next = null;

                n.Next = slow;
                if (root == null)
                {
                    root = n;
                }
                else
                {
                    slow.Next = root;
                    root = n;
                }

                slow = NextPtr;
            }
        }
    }
}

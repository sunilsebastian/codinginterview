using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class ConnectNodesAtSameLevel
    {
        public static void ConnectNextpointer(NodeN root)
        {
            NodeN childHead = null;
            NodeN child = null;
            while (root != null)
            {
                while (root != null)
                {
                    if (root.Left != null)
                    {
                        if (childHead != null)
                        {
                            child.Next = root.Left;
                        }
                        else
                        {
                            childHead = root.Left;
                        }
                        child = root.Left;

                    }
                    if (root.Right != null)
                    {
                        if (childHead != null)
                        {
                            child.Next = root.Right;
                        }
                        else
                        {
                            childHead = root.Right;
                        }
                        child = root.Right;
                    }

                    root = root.Next;

                }

                root = childHead;
                childHead = null;
                child = null;


            }

        }

        public static void ConnectNextpointerMethod1(NodeN root)
        {
            Queue<NodeN> q = new Queue<NodeN>();
            if (root == null)
                return;
            q.Enqueue(root);
            q.Enqueue(null);

            while (q.Count() != 0)
            {
                var n = q.Dequeue();
                if (n != null)
                {
                    n.Next = q.Peek();
                    if (n.Left != null)
                    {
                        q.Enqueue(n.Left);
                    }
                    if (n.Right != null)
                    {
                        q.Enqueue(n.Right);
                    }
                }
                else
                {
                    if (q.Count() != 0)
                        q.Enqueue(null);

                }
            }

        }
    }

}

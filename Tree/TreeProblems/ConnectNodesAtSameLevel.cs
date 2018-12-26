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
            while(root!=null)
            {
                while (root != null)
                {
                    if(root.Left!=null)
                    {
                        if(childHead!=null)
                        {
                            child.Next = root.Left;
                        }
                        else
                        {
                            childHead = root.Left;
                        }
                        child = root.Left;

                    }
                    if(root.Right!=null)
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
    }
}

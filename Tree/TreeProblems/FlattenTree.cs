using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class FlattenTree
    {
        public static Node GetFlattenTree(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            Node p = root;

            while (p != null || stack.Count>0)
            {

                if (p.Right != null)
                {
                    stack.Push(p.Right);


                }

                if (p.Left != null)
                {
                    p.Right = p.Left;
                    p.Left = null;
                }
                else if (stack.Count>0)
                {
                    Node temp = stack.Pop();
                    p.Right = temp;
                }

                p = p.Right;
            }

            return p;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class InorderSuccessor
    {
        public static Node GetInorderSuccessor(Node root, Node p)
        {
            if (root == null)
                return null;

            Node next = null;
            Node c = root;
            while (c != null && c.Data != p.Data)
            {
                
                if (c.Data > p.Data)
                {
                    //next node will be the last node we take left turn
                    next = c;
                    c = c.Left;
                }
                else
                {
                    c = c.Right;
                }
            }

            if (c == null)
                return null;

            if (c.Right == null)
                return next;
            //when the node has a right subtree, should take the minimum of the subtree which is the left most.
            c = c.Right;
            while (c.Left != null)
                c = c.Left;

            return c;
        }
    }
}

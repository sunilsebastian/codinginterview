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
            Node current = root;
            while (current != null && current.Data != p.Data)
            {
                
                if (current.Data > p.Data)
                {
                    //next node will be the last node we take left turn
                    next = current;
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            if (current == null)
                return null;

            if (current.Right == null)
                return next;
            //when the node has a right subtree, should take the minimum of the subtree which is the left most.
            current = current.Right;
            while (current.Left != null)
                current = current.Left;

            return current;
        }
    } 
}

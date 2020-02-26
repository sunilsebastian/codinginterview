using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class InOrderPredecessor
    {
        public static Node GetInorderPredecessorBST(Node root, Node p)
        {
            if (root == null)
                return null;

            Node next = null;
            Node current = root;
            while (current != null && current.Data != p.Data)
            {

                if (current.Data > p.Data)
                {
                   
                  
                    current = current.Left;
                }
                else
                {
                    //next node will be the last node we take right turn
                    next = current;
                    current = current.Right;
                }
            }

            if (current == null)
                return null;

            if (current.Left == null)
                return next;
            //when the node has a left subtree, should take the maximum of the subtree which is the right most.
            current = current.Left;
            while (current.Right != null)
                current = current.Right;

            return current;
        }

        

        public static int GetInorderPredecessorBT(Node root, int target)
        {
            bool flag = false;
            int inorderSuccessor = 0; ;
            Stack<Node> stk = new Stack<Node>();
            while (true)
            {
                if (root != null)
                {
                    stk.Push(root);
                    root = root.Right;
                }
                else
                {
                    if (stk.Count() == 0)
                        break;
                    root = stk.Pop();
                    if (flag == true)
                    {
                        inorderSuccessor = root.Data;
                        break;
                    }

                    if (root.Data == target)
                    {
                        flag = true;
                    }
                    Console.Write(root.Data + " ");
                    root = root.Left;
                }
            }
            return inorderSuccessor;
        }
    }
}

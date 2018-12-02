using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class PreOrderTraversal
    {
        public static void Traverse(Node root)
        {
            Stack<Node> stk = new Stack<Node>();
          
            if (root == null)
                return;
            stk.Push(root);

            while (stk.Count != 0)
            {
                var node = stk.Pop();
                Console.Write(node.Data + " ");
                if (node.Right != null)
                {
                    stk.Push(node.Right);
                }

                if (node.Left != null)
                {
                    stk.Push(node.Left);
                }
            }

        }
    }
}

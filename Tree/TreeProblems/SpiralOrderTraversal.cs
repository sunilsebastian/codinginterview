using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class SpiralOrderTraversal
    {
        public static void Traverse(Node root)
        {
            Stack<Node> s1 = new Stack<Node>();
            Stack<Node> s2 = new Stack<Node>();

            if (root == null)
                return;
            s1.Push(root);

            while (s1.Count != 0 || s2.Count != 0)
            {
                while (s1.Count != 0)
                {
                    var node = s1.Pop();
                    Console.Write(node.Data + " ");
                    if (node.Left != null)
                    {
                        s2.Push(node.Left);
                    }
                    if (node.Right != null)
                    {
                        s2.Push(node.Right);
                    }
                }

                while (s2.Count != 0)
                {
                    var node = s2.Pop();
                    Console.Write(node.Data + " ");
                    if (node.Right != null)
                    {
                        s1.Push(node.Right);
                    }
                    if (node.Left != null)
                    {
                        s1.Push(node.Left);
                    }
                }
               
            }

        }
    }
}

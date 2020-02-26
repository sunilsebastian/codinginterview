using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class LevelOrderNewLine
    {
        public static void Traverse(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            if (root == null)
                return;
            q.Enqueue(root);
            q.Enqueue(null);

            while (q.Count()!=0)
            {
               var n= q.Dequeue();
                if(n!=null)
                {
                    Console.Write(n.Data + " ");
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
                    Console.WriteLine();
                    if(q.Count()!=0)
                        q.Enqueue(null);

                }
            }
        }

        //Better  solution no need of null
        static void PrintLevelOrder(Node root)
        {
            if (root == null)
                return;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (true)
            {
                int nodeCount = q.Count;
                if (nodeCount == 0)
                    break;
                while (nodeCount > 0)
                {
                    Node node = q.Peek();
                    Console.Write(node.Data + " ");
                    q.Dequeue();
                    if (node.Left != null)
                        q.Enqueue(node.Left);
                    if (node.Right != null)
                        q.Enqueue(node.Right);
                    nodeCount--;
                }
                Console.WriteLine();
            }
        }
    }
}

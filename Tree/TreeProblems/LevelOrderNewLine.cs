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
    }
}

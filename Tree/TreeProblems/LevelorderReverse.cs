using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class LevelorderReverse
    {
        public static void Traverse(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            Stack<Node> stk = new Stack<Node>();
            if (root == null)
                return;
            q.Enqueue(root);
            while (q.Count() != 0)
            {
                Node n = q.Dequeue();
                stk.Push(n);
                if (n.Left != null)
                {
                    q.Enqueue(n.Left);
                }
                if (n.Right != null)
                {
                    q.Enqueue(n.Right);
                }
            }

            while (stk.Count() != 0)
            {
                Node n = stk.Pop();
                Console.Write(n.Data + " ");

            }
        }
    }
}

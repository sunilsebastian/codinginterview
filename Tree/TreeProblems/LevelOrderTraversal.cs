 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class LevelOrderTraversal
    {
        public static void Traverse(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while(q.Count!=0)
            {
              var node=  q.Dequeue();
                Console.Write(node.Data + " ");
                if(node.Left!=null)
                {
                    q.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class RightView
    {
        public List<int> RightSideView(Node root)
        {
            List<int> res = new List<int>();
            if (root == null)
                return res;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count>0)
            {
                int count = queue.Count;
                while (count > 0)
                {
                    count--;
                    Node temp = queue.Dequeue();
                    if (temp.Left != null)
                        queue.Enqueue(temp.Left);
                    if (temp.Right != null)
                        queue.Enqueue(temp.Right);

                    if (count == 0)
                    {
                        res.Add(temp.Data);
                    }
                }
            }

            return res;
        }
    }
}

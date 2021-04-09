using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class KDistancefromTarget
    {
        Dictionary<Node, Node> parent;
        public List<int> DistanceK(Node root, Node target, int K)
        {
            parent = new Dictionary<Node, Node>();
            setParent(root, null);

            //Set to store visited node
            HashSet<Node> seen = new HashSet<Node>();
            seen.Add(target);
            seen.Add(null);

            //Starting point of BFS is target node
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(target);

            while (queue.Count()!=0 && K-- > 0)
            {
                int currSize = queue.Count();
                for (int i = 0; i < currSize; i++)
                {
                    Node node = queue.Dequeue();
                    if (!seen.Contains(node.Left))
                    {
                        seen.Add(node.Left);
                        queue.Enqueue(node.Left);
                    }
                    if (!seen.Contains(node.Right))
                    {
                        seen.Add(node.Right);
                        queue.Enqueue(node.Right);
                    }
                    Node par = parent[node];
                    if (!seen.Contains(par))
                    {
                        seen.Add(par);
                        queue.Enqueue(par);
                    }
                }
            }
            List<int> ans = new List<int>();
            while(queue.Count()!=0)
            {
                ans.Add(queue.Dequeue().Data);
            }
         
            return ans;
        }

        public void setParent(Node node, Node par)
        {
            if (node != null)
            {
                parent.Add(node, par);
                setParent(node.Left, node);
                setParent(node.Right, node);
            }
        }
    }
}


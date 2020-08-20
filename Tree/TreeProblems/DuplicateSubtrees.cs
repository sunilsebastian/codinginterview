using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class DuplicateSubtrees
    {
        Dictionary<int, Node> dict = new Dictionary<int,Node>();
        public List<Node> GetDuplicateTrees(Node root)
        {
            List<Node> lst = new List<Node>();

            PreOrder(root,lst);

            return lst;

        }
        public void PreOrder(Node n, List<Node> lst)
        {
            if (n == null) return;

            if (dict.ContainsKey(n.Data))
            {
                Node oldNode = dict[n.Data];

                bool res = SameTree.IsSameTree(n, oldNode);
                if(res)
                {
                    lst.Add(oldNode);
                }
            }
            else
            {
                dict.Add(n.Data, n);
            }

            PreOrder(n.Left,lst);
            PreOrder(n.Right,lst);

        }
    }
}

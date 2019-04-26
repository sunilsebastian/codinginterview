using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class CountNodes
    {
        public int GetNodeCount(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            return GetNodeCount(root.Left) + GetNodeCount(root.Right) +1;
        }
    }
}

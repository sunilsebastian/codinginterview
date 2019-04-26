using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class SymmetricTree
    {
        public bool isSymmetric(Node root)
        {
            if (root == null)
                return true;
            return isSymmetric(root.Left, root.Right);
        }

        public bool isSymmetric(Node l, Node r)
        {
            if (l == null && r == null)
            {
                return true;
            }
            else if (r == null || l == null)
            {
                return false;
            }

            if (l.Data != r.Data)
                return false;

            if (!isSymmetric(l.Left, r.Right))
                return false;
            if (!isSymmetric(l.Right, r.Left))
                return false;

            return true;
        }
    }
}

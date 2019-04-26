using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class LowestCommonAncestorBST
    {
        public static Node FindLeastCommonAncester(Node root, int n1, int n2)
        {
            if (root == null) return null;

            if (root.Data<n1 && root.Data<n2)
            {
               return  FindLeastCommonAncester(root.Right, n1, n2);
            }
            else if (root.Data > n1 && root.Data >n2)
            {
               return  FindLeastCommonAncester(root.Left, n1, n2);
            }

           else  return root;
        }
    }
}

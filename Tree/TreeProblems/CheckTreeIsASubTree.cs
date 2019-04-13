using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class CheckTreeIsASubTree
    {

        bool isSubtree(Node root, Node subtree)
        {
            /* base cases */
            if (subtree == null)
                return true;

            if (root == null)
                return false;

            /* Check the tree with root as current node */
            if (SameTree.IsSameTree(root, subtree))
                return true;

            /* If the tree with root as current  
              node doesn't match then try left 
              and right subtrees one by one */
            return isSubtree(root.Left, subtree)
                    || isSubtree(root.Right,subtree);
        }
    }
}

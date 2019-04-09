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

        bool isSubtree(Node T, Node S)
        {
            /* base cases */
            if (S == null)
                return true;

            if (T == null)
                return false;

            /* Check the tree with root as current node */
            if (SameTree.IsSameTree(T, S))
                return true;

            /* If the tree with root as current  
              node doesn't match then try left 
              and right subtrees one by one */
            return isSubtree(T.Left, S)
                    || isSubtree(T.Right, S);
        }
    }
}

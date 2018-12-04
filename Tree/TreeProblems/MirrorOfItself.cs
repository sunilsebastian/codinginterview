using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class MirrorOfItself
    {
        public static bool IsMirrorOfItself(Node oRoot,Node mRoot)
        {
            if(oRoot==null && mRoot==null)
            {
                return true;
            }

            if (oRoot == null || mRoot == null)
            {
                return false;
            }

            var left = IsMirrorOfItself(oRoot.Left, mRoot.Right);
            if (left == false) return false;

            var right = IsMirrorOfItself(oRoot.Right, mRoot.Left);
            if (right == false) return false;

            return true;
        }
    }
}

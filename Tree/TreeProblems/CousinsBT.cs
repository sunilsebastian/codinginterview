using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class CousinsBT
    {

        public static bool IsCousins(Node root, int x, int y)
        {
            Node prev = null;
        
            int[] d1= GetDepth(root, prev, 0, x);
            int[] d2 = GetDepth(root, prev, 0, y);

            if (d1[0] == -1 || d2[0] == -1)
                return false;

            if (d1[0] == d2[0] && d1[1]!=d2[1])
                return true;
            return false;
           
        }

        public static int[] GetDepth(Node root,Node prev,int depth ,int val)
        {
            if (root == null)
                return new int[] { -1, -1 };

            if (root.Data == val)
            {
                return new int[] { depth, (prev==null)?-1:prev.Data};
            }
            int[] left = GetDepth(root.Left, root, depth + 1, val);
            if (left[0] != -1)
                return left;
            int[] right = GetDepth(root.Right, root, depth + 1, val);
            if (right[0] != -1)
                return right;
            return new int[] { -1, -1 };
        }
    }
}

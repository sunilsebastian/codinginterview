using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class MaxPathSum
    {
        //solution is versy similar to diameter of a tree
        // there it is +1 here it is +root.value;
        public static  int GetMaxPathSum(Node root)
        {
            MaxPath path = new MaxPath();
            path.val = Int32.MinValue;
            GetMaxPathSumHelper(root, path);
            return path.val;
        }
        public static int GetMaxPathSumHelper(Node root, MaxPath path)
        {
            if (root == null) return 0;

            // to support case [2,-1] need to take Max(0,func)
            var left = Math.Max(0, GetMaxPathSumHelper(root.Left, path));
            var right = Math.Max(0, GetMaxPathSumHelper(root.Right, path));

            var currMax = left + right + root.Data;
            path.val = Math.Max(currMax, path.val);

            return Math.Max(left, right) + root.Data;
        }

    }

    public class MaxPath
    {
        public int val { get; set; }
    }


}


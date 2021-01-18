using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{

    //Input: root = [4,2,5,1,3], target = 3.714286

    //    4
    //   / \
    //  2   5
    // / \
    //1   3
    public class NearestTargetInBST
    {
        public class Solution
        {
            int result;
            double min = Double.MaxValue;

            public int closestValue(Node root, double target)
            {
                helper(root, target);
                return result;
            }

            public void helper(Node root, double target)
            {
                if (root == null)
                    return;

                if (Math.Abs(root.Data - target) < min)
                {
                    min = Math.Abs(root.Data - target);
                    result = root.Data;
                }

                if (target < root.Data)
                {
                    helper(root.Left, target);
                }
                else
                {
                    helper(root.Right, target);
                }
            }
        }
    }
}

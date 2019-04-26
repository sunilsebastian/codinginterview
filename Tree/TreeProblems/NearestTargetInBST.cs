using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class NearestTargetInBST
    {
        public class Solution
        {
            int goal;
            double min = Double.MaxValue;

            public int closestValue(Node root, double target)
            {
                helper(root, target);
                return goal;
            }

            public void helper(Node root, double target)
            {
                if (root == null)
                    return;

                if (Math.Abs(root.Data - target) < min)
                {
                    min = Math.Abs(root.Data - target);
                    goal = root.Data;
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

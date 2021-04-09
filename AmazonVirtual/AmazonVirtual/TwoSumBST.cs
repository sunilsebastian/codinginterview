using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class TwoSumBST
    {
        //https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> hs = new HashSet<int>();
            return FindTargetHelper(root, k, hs);

        }

        public bool FindTargetHelper(TreeNode root, int k, HashSet<int> hs)
        {
            if (root == null)
                return false;

            if (hs.Contains(k - root.val))
                return true;
            else
                hs.Add(root.val);

            var left = FindTargetHelper(root.left, k, hs);
            if (left == true) return true;

            var right = FindTargetHelper(root.right, k, hs);
            if (right == true) return true;

            return false;


        }
    }
}

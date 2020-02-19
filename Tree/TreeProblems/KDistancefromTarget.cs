using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class KDistancefromTarget
    {
        public static List<int> res;
        public static  List<int> DistanceK(Node root, int target, int K)
        {
            res = new List<int>();
            GetNodesDistK(root, target, K);
            return res;
        }

        private static int GetNodesDistK(Node root, int target, int K)
        {
            if (root == null)
            {
                // no target node found
                return -1;
            }
            if (root.Data == target)//.Data)
            {
                FindChild(root, K);
                //when go to the root distance reduces by 1;
                return K - 1;
            }
            int left = GetNodesDistK(root.Left, target, K);
            if (left > 0)
            {
                //there can be nodes at k distance at right.
                FindChild(root.Right, left - 1);
                return left - 1;
            }
            int right = GetNodesDistK(root.Right, target, K);
            if (right > 0)
            {
                //there can be nodes at k distance at left.
                FindChild(root.Left, right - 1);
                return right - 1;
            }
            if (left == 0 || right == 0)
            {
                res.Add(root.Data);
            }
            return -1;
        }

        //Find all child of target node with K distance
        private static void FindChild(Node root, int K)
        {
            if (root == null || K < 0)
            {
                return;
            }
            if (K == 0)
            {
                res.Add(root.Data);
                return;
            }
            FindChild(root.Left, K - 1);
            FindChild(root.Right, K - 1);
        }
    }
}


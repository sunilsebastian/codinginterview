using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    //for Kth Largest
    //go to the right fist then go t the left
    public class BSTKthSmallest
    {
        public int KthSmallest(Node root, int k)
        {
            Smallest smallest = new Smallest();
            return KthSmallestHelper(root, k, smallest);
        }

        public int KthSmallestHelper(Node root, int k, Smallest smallest)
        {
            if (root == null)
                return -1;

            var left = KthSmallestHelper(root.Left, k, smallest);
            if (left != -1)
            {
                return left;
            }
            smallest.Count++;
            if (smallest.Count == k)
            {
                return root.Data;
            }

            return KthSmallestHelper(root.Right, k, smallest);
        }
    }
    public class Smallest
    {
        public int Count { get; set; }
    }

}

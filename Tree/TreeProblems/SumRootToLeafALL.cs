using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{

    //https://leetcode.com/problems/sum-root-to-leaf-numbers/
    //Input: [4,9,0,5,1]
    //    4
    //   / \
    //  9   0
    // / \
    //5   1
    //Output: 1026
    //Explanation:
    //The root-to-leaf path 4->9->5 represents the number 495.
    //The root-to-leaf path 4->9->1 represents the number 491.
    //The root-to-leaf path 4->0 represents the number 40.
    //Therefore, sum = 495 + 491 + 40 = 1026.
    public class SumRootToLeafALL
    {
      
        public int SumNumbers(Node root)
        {
            Counter counter = new Counter();
            preorder(root, 0, counter);
            return counter.val;
        }
        public void preorder(Node r, int currNumber, Counter counter)
        {
            if (r == null)
                return;

            //this check is very important because if we update the global value in r==null
            //same value at the leaf will be added twice

            // if it's a leaf, update root-to-leaf sum
            if (r.Left == null && r.Right == null)
            {
                currNumber = currNumber * 10 + r.Data;
                counter.val += currNumber;
                return;
            }

            currNumber = currNumber * 10 + r.Data;
            preorder(r.Left, currNumber, counter);
            preorder(r.Right, currNumber, counter);
        }

    }
    public class Counter
    {
        public int val { get; set; }
    }
}

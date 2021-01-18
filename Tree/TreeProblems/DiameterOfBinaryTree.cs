using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    //https://leetcode.com/problems/diameter-of-binary-tree/
    //The logic is simple.While finding the depth of each node , find the diameter of that node as well.
    //If the diameter of current node is larger than the global diameter.then set current diameter as the global diameter;

    // height=Math.Max(left_height, right_height) + 1;
    //diameter=left_height + right_height;  update global diameter always

    //refer this problem too : https://leetcode.com/problems/binary-tree-maximum-path-sum/

    public class DiameterOfBinaryTree
    {
        public static int diameter = 0;
        public static int GetDiameterOfBinaryTree(Node root)
        {
            FindDiameterHelper(root, ref diameter);
            return diameter;
        }
        private static  int FindDiameterHelper(Node root, ref int  diameter)
        {
           
            if (root == null)
                return 0;

            int left_height = FindDiameterHelper(root.Left, ref diameter);
            int right_height = FindDiameterHelper(root.Right, ref diameter);


            int max_diameter = left_height + right_height; //+ 1;

            diameter = Math.Max(diameter, max_diameter);

            return Math.Max(left_height, right_height) + 1;
        }
    }
}

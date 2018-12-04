using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class LowestCommonAncesterBinaryTree
    {

        public static Node FindLeastCommonAncester(Node root, int n1, int n2)
        {
            if (root == null)
                return null;
            if (root.Data == n1 || root.Data == n2)
                return root;

            Node left = FindLeastCommonAncester(root.Left, n1, n2);
            Node right = FindLeastCommonAncester(root.Right, n1, n2);
            if (left == null && right == null)
                return null;

            if (left != null && right != null)
                return root;

            return left ?? right;  //(left!=null)?  left: right;
        }
    }
}

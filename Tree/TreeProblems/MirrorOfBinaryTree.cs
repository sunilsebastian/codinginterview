using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class MirrorOfBinaryTree
    {
        public static  Node MirrorTree(Node root)
        {
            if(root==null)
            {
                return null;
            }

            var left = MirrorTree(root.Left);
            var right = MirrorTree(root.Right);
            if (left == null && right == null)
                return root;
            root.Left = right;
            root.Right = left;

            return root;
        }

        
    }
}

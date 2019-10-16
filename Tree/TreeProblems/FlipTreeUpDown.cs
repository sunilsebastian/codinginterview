using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class FlipTreeUpDown
    {
        public static Node FlipUpsideDown(Node root)
        {
            var current = root;
            while (current.Left != null)
            {
                current = current.Left;
            }

            flipUpsideDownHelper(root);

            return current;
        }

        public static Node flipUpsideDownHelper(Node root)
        {

            if (root == null) return null;

            if (root.Left == null)
            {
                return root;
            }

            var temp = root.Right;
            var result = flipUpsideDownHelper(root.Left);
            result.Right = root;
            result.Left = temp;
            root.Right = null;
            root.Right = null;

            return root;
        }

    }
}

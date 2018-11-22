using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class HeightOfBinaryTree
    {
        public static int GetHeight(Node root)
        {
            if (root == null)
                return 0;
            var lHeight = GetHeight(root.Left);
            var rHeight = GetHeight(root.Left);

            return Math.Max(lHeight, rHeight) + 1;
        }

    }
}

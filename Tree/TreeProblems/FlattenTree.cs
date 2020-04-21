using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{

     //     1
     //   /   \
     //  2     5
     // / \     \
     //3   4     6
    public class FlattenTree
    {
        private static Node prev = null;
        public static void  Flatten(Node root)
        {

            if (root == null) return; // base case 

            Flatten(root.Right);
            Flatten(root.Left); 

            root.Right = prev;
            root.Left = null;
            prev = root;
        }
    }
}

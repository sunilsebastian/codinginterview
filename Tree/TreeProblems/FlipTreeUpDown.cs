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

            return flipUpsideDownHelper(root);

        }

        public static Node flipUpsideDownHelper(Node root)
        {

            if (root == null)
                return null;

            if (root.Left == null)
            {
                return root;
            }

            var result = flipUpsideDownHelper(root.Left);
            root.Left.Right = root;
            root.Left.Left = root.Right;
            root.Right = null;
            root.Left = null;

            //always bubbles up the extreme left node
            return result;
        }


        public static Node flipUpsideDownHelper1(Node root, Node prev)
        {
            if (root == null)
                return prev;


            //result/extreme left node  stay same
            var result = flipUpsideDownHelper1(root.Left, root);
            if (prev != null)
            {
                prev.Left.Right = prev;
                prev.Left.Left = prev.Right;
                prev.Left = null;
                prev.Right = null;
              
            }


            //always bubbles up the extreme left node
            return result;
        }
    }
}

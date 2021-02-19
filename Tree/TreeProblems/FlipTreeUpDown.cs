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

            return flipUpsideDownHelper(root,null);

        }

       


        public static Node flipUpsideDownHelper(Node root, Node prev)
        {
            if (root == null)
                return prev;


            //result/extreme left node  stay same
            var result = flipUpsideDownHelper(root.Left, root);
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

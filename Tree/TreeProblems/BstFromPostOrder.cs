using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class BstFromPostOrder
    {
        public Node BstFromPreorder(int[] preorder)
        {
            PostOrderIndex postOrderIndex = new PostOrderIndex();
            postOrderIndex.Index = preorder.Length-1;
            return BstFromPreorder(preorder, Int32.MinValue, Int32.MaxValue, postOrderIndex);
        }

        public Node BstFromPreorder(int[] preorder, int min, int max, PostOrderIndex postOrderIndex)
        {
            if (postOrderIndex.Index <0)
                return null;
            if (preorder[postOrderIndex.Index] < min || preorder[postOrderIndex.Index] > max)
            {
                return null;
            }
            // -- instead of ++
            Node root = new Node(preorder[postOrderIndex.Index--]);
            //right before left
            root.Right = BstFromPreorder(preorder, root.Data, max, postOrderIndex);
            root.Left = BstFromPreorder(preorder, min, root.Data, postOrderIndex);
           

            return root;
        }
    }
  
}

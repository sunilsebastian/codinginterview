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
        public static Node BstFrmPostOrder(int[] postorder)
        {
            PostOrderIndex postOrderIndex = new PostOrderIndex();
            postOrderIndex.Index = postorder.Length-1;
            return BstFrmPostorder(postorder, Int32.MinValue, Int32.MaxValue, postOrderIndex);
        }

        public static Node BstFrmPostorder(int[] postorder, int min, int max, PostOrderIndex postOrderIndex)
        {
            if (postOrderIndex.Index <0)
                return null;
            if (postorder[postOrderIndex.Index] < min || postorder[postOrderIndex.Index] > max)
            {
                return null;
            }
            // -- instead of ++
            Node root = new Node(postorder[postOrderIndex.Index--]);
            //right before left
            root.Right = BstFrmPostorder(postorder, root.Data, max, postOrderIndex);
            root.Left = BstFrmPostorder(postorder, min, root.Data, postOrderIndex);
           

            return root;
        }
    }
  
}

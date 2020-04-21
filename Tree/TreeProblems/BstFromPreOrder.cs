using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class BstFromPreOrder
    {
        public Node BstFromPreorder(int[] preorder)
        {
            PreOrderIndex preOrderIndex = new PreOrderIndex();
            preOrderIndex.Index = 0;
            return BstFromPreorder(preorder, Int32.MinValue, Int32.MaxValue, preOrderIndex);
        }

        public Node BstFromPreorder(int[] preorder, int min, int max, PreOrderIndex preOrderIndex)
        {
            if (preOrderIndex.Index == preorder.Length)
                return null;
            if (preorder[preOrderIndex.Index] < min || preorder[preOrderIndex.Index] > max)
            {
                return null;
            }

            Node root = new Node(preorder[preOrderIndex.Index++]);
            root.Left = BstFromPreorder(preorder, min, root.Data, preOrderIndex);
            root.Right = BstFromPreorder(preorder, root.Data, max, preOrderIndex);

            return root;
        }
    }
    public class PreOrderIndex
    {
        public int Index { get; set; }
    }
}

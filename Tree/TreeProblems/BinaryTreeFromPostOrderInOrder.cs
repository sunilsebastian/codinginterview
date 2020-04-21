using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public  class PostOrderIndex
    {
        public int Index { get; set; }
    }
    public class BinaryTreeFromPostOrderInOrder
    {
       
        public static Node BuildTree(int[] postorder,int[] inorder)
        {
            PostOrderIndex postOrderIndex = new PostOrderIndex();
            Dictionary<int, int> inorderDict = new Dictionary<int, int>();
            for(int i=0;i<inorder.Length;i++)
            {
                inorderDict.Add(inorder[i], i);

            }

            postOrderIndex.Index = postorder.Length - 1;

            return BuildTreeHelper(postorder, 0, postorder.Length - 1, postOrderIndex, inorderDict);
        }

        public static Node BuildTreeHelper(int[] postorder,int start,int end, PostOrderIndex postOrderIndex, Dictionary<int, int> inorderDict)
        {
            if (start > end)
                return null;

            Node root = new Node(postorder[postOrderIndex.Index--]);

            int inorderIndex = inorderDict[root.Data];

            root.Right = BuildTreeHelper(postorder,inorderIndex + 1, end, postOrderIndex, inorderDict);
            root.Left = BuildTreeHelper(postorder,start, inorderIndex-1, postOrderIndex, inorderDict);
            return root;

        }
    }
}

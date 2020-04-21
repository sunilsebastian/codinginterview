using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    //Time Complexity: O(n^2). Worst case occurs when tree is left skewed
    public class BinaryTreeFromPreOrderInOrder
    {
        public Node Root { get; set; }

        public static int preOrderIndex = 0;

        public BinaryTreeFromPreOrderInOrder()
        {
            Root = null;
        }

        public void BuildTree(int[] preOrder, int[] inOrder)
        {
            this.Root = BuildTree(preOrder, inOrder, 0, inOrder.Length - 1);
        }

        private Node BuildTree(int[] preOrder, int[] inOrder, int start, int end)
        {
            if (start > end)
                return null;
            Node root = new Node(preOrder[preOrderIndex++]);

            if (start == end)
                return root;

            int inOrderIndex = FindInOrderIndex(inOrder, root.Data, start, end);


            root.Left = BuildTree(preOrder, inOrder, start, inOrderIndex - 1);
            root.Right = BuildTree(preOrder, inOrder, inOrderIndex + 1, end);

            return root;
        }

        private int FindInOrderIndex(int[] inOrder, int data, int start, int end)
        {
            int idx = 0;
            for (int i = start; i <= end; i++)
            {
                if (inOrder[i] == data)
                {
                    idx = i;
                    break;
                }
            }
            return idx;
        }


    }
}

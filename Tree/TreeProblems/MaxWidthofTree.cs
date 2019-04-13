using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class MaxWidthofTree
    {
        public static int GetMaxWidth(Node root)
        {
            int h = HeightOfBinaryTree.GetHeight(root);
            int[] levelWidth = new int[h];
            GetMaxWidth(root, levelWidth, 0);

            var max = 0;
            for (int i = 0; i < levelWidth.Length; i++)
            {
                if (max < levelWidth[i])
                {
                    max = levelWidth[i];
                }
            }
            return max;

        }

        public static void GetMaxWidth(Node root, int[] levelWidth, int level)
        {
            if (root != null)
            {
                levelWidth[level]++;
                GetMaxWidth(root.Left, levelWidth, level + 1);
                GetMaxWidth(root.Right, levelWidth, level + 1);


            }

        }

        public static int WidthOfBinaryTreewithNull(Node root)
        {
            if (root == null) { return 0; }
            int max = 1;
            Queue<Node> treeList = new Queue<Node>();
            Queue<int> intList = new Queue<int>();
            treeList.Enqueue(root);
            intList.Enqueue(1);
            while (treeList.Count > 0)
            {
                int size = treeList.Count;
                int l = intList.Peek();
                for (int i = 0; i < size; i++)
                {

                    Node r = treeList.Dequeue();
                    int depth = intList.Dequeue();
                    if (r.Left != null)
                    {
                        treeList.Enqueue(r.Left);
                        intList.Enqueue(2 * depth);
                    }
                    if (r.Right != null)
                    {
                        treeList.Enqueue(r.Right);
                        intList.Enqueue(2 * depth + 1);
                    }
                    max = Math.Max(max, depth - l + 1);
                }

            }


            return max;
        }
    }
}

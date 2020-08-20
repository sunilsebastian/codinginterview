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
            Queue<(Node,int)> q = new Queue<(Node,int)>();
         
            //inserting node and currentHeapIndex of BT
            q.Enqueue((root,1));
          
            while (q.Count > 0)
            {
                int size = q.Count;
                int startHeapIndex = q.Peek().Item2;
                int heapCurrentIndex = 0;
                for (int i = 0; i < size; i++)
                {
                    var qItem = q.Dequeue();
                    //end of the loop/level it will be last index at the current level
                    heapCurrentIndex = qItem.Item2;
                    Node n = qItem.Item1;
                    if (n.Left != null)
                    {
                        q.Enqueue((n.Left, 2 * heapCurrentIndex));
                     
                    }
                    if (n.Right != null)
                    {
                        q.Enqueue((n.Right, 2 * heapCurrentIndex+1));
                     
                    }
                }
                max = Math.Max(max, heapCurrentIndex - startHeapIndex + 1);
            }

            return max;
        }
    }
}

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
            GetMaxWidth(root,  levelWidth, 0);

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

        public static void  GetMaxWidth(Node root, int[] levelWidth,int level)
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
            Queue<AnnotatedNode> queue = new Queue<AnnotatedNode>();
            queue.Enqueue(new AnnotatedNode(root, 0, 0));
            int curLevel = 0, width = 0; 
            while (queue.Count!=0)
            {
                AnnotatedNode a = queue.Dequeue();
                if (a.node != null)
                {
                    queue.Enqueue(new AnnotatedNode(a.node.Left, a.level + 1, a.nodeIndex * 2));
                    queue.Enqueue(new AnnotatedNode(a.node.Right, a.level + 1, a.nodeIndex * 2 + 1));
                    if (curLevel != a.level)
                    {
                        curLevel = a.level;
                    }
                    width = Math.Max(width, a.nodeIndex + 1);
                }
            }
            return width;
        }
    }

    class AnnotatedNode
    {
        public Node node;
        public int level, nodeIndex;
        public AnnotatedNode(Node n, int d, int p)
        {
            node = n;
            level = d;
            nodeIndex = p;
        }
    }
 }

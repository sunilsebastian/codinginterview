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
            int curDepth = 0, left = 0, ans = 0;
            while (queue.Count!=0)
            {
                AnnotatedNode a = queue.Dequeue();
                if (a.node != null)
                {
                    queue.Enqueue(new AnnotatedNode(a.node.Left, a.depth + 1, a.pos * 2));
                    queue.Enqueue(new AnnotatedNode(a.node.Right, a.depth + 1, a.pos * 2 + 1));
                    if (curDepth != a.depth)
                    {
                        curDepth = a.depth;
                        left = a.pos;
                    }
                    ans = Math.Max(ans, a.pos - left + 1);
                }
            }
            return ans;
        }
    }

    class AnnotatedNode
    {
        public Node node;
        public int depth, pos;
        public AnnotatedNode(Node n, int d, int p)
        {
            node = n;
            depth = d;
            pos = p;
        }
    }
 }

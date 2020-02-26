using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class MinimumSumLevel
    {

        public static int FindMinimumSumLevel(Node root)
        {
            int h = HeightOfBinaryTree.GetHeight(root);
            int[] levelSum = new int[h];
            GetSum(root, levelSum, 0);

            int min = levelSum[0];
            int LevelIndex = 0;
            for(int i=1;i< levelSum.Length;i++)
            {
                if(levelSum[i]<min)
                {
                    LevelIndex = i;
                    min = levelSum[i];

                }
            }
            return LevelIndex+1;
        }

        public static void GetSum(Node root, int[] levelSum, int level)
        {
            if (root != null)
            {
                levelSum[level] += root.Data;
                GetSum(root.Left, levelSum, level + 1);
                GetSum(root.Right, levelSum, level + 1);
            }

        }

        //Can be used for minimum sum level too
        public int MaxLevelSum(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int level = 0;
            int max = Int32.MinValue;
            int maxLevel = -1;
            while (q.Count != 0)
            {
                int currentMax = 0;
                int count = q.Count;
                // if(count==0) break;
                level++;

                while (count > 0)
                {
                    Node node = q.Dequeue();

                    currentMax = currentMax + node.Data;
                    if (node.Left != null)
                    {
                        q.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        q.Enqueue(node.Right);
                    }
                    count--;
                }

                if (currentMax > max)
                {
                    max = currentMax;
                    maxLevel = level;

                }
            }
            return maxLevel;
        }

    }
}

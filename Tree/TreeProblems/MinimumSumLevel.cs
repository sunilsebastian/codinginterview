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


        public static int FindMinimumSumLevel_1(Node root)
        {
            if (root == null) return 0;
          


            Queue<Node> q1 = new Queue<Node>();
            Queue<Node> q2 = new Queue<Node>();
            int sum = 0;
            int level = 0;
            int currentsum = 0;

            q1.Enqueue(root);
            sum = root.Data;
            level++;
            while (q1.Count != 0 || q2.Count!=0)
            {
                while (q1.Count != 0)
                {
                    var node = q1.Dequeue();
                    //Console.Write(node.Data + " ");
                    if (node.Left != null)
                    {
                        currentsum += node.Left.Data;
                        q2.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        currentsum += node.Left.Data;
                        q2.Enqueue(node.Right);
                    }
                }
                if (currentsum < sum)
                    sum = currentsum;
                level++;
                currentsum = 0;
                while (q2.Count != 0)
                {
                    var node = q2.Dequeue();
                    Console.Write(node.Data + " ");
                    if (node.Left != null)
                    {
                        currentsum += node.Left.Data;
                        q1.Enqueue(node.Left);
                    }

                    if (node.Right != null)
                    {
                        currentsum += node.Left.Data;
                        q1.Enqueue(node.Right);
                    }
                }
                if (currentsum < sum)
                    sum = currentsum;
                level++;
                currentsum = 0;
            }

            return level;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class BSTLongestConsecutiveSequence
    {
        public static  int LongestConsecutive(Node root)
        {
            if (root == null)
                return 0;

            Queue<Node> nodeQueue = new Queue<Node>();
            Queue<int> sizeQueue = new Queue<int>();

            nodeQueue.Enqueue(root);
            sizeQueue.Enqueue(1);
            int max = 1;

            while (nodeQueue.Count>0)
            {
                Node head = nodeQueue.Dequeue();
                int size = sizeQueue.Dequeue();

                if (head.Left != null)
                {
                    int leftSize = size;
                    if (head.Data == head.Left.Data - 1)
                    {
                        leftSize++;
                        max = Math.Max(max, leftSize);
                    }
                    else
                    {
                        leftSize = 1;
                    }

                    nodeQueue.Enqueue(head.Left);
                    sizeQueue.Enqueue(leftSize);
                }

                if (head.Right != null)
                {
                    int rightSize = size;
                    if (head.Data == head.Right.Data - 1)
                    {
                        rightSize++;
                        max = Math.Max(max, rightSize);
                    }
                    else
                    {
                        rightSize = 1;
                    }

                    nodeQueue.Enqueue(head.Right);
                    sizeQueue.Enqueue(rightSize);
                }

            }

            return max;
        }
    }
}

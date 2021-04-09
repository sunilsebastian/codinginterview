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
        public static int LongestConsecutive(Node root)
        {
            if (root == null)
                return 0;

            Queue<Node> nodeQueue = new Queue<Node>();
            Queue<int> sizeQueue = new Queue<int>();

            nodeQueue.Enqueue(root);
            sizeQueue.Enqueue(1);
            int max = 1;

            while (nodeQueue.Count > 0)
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

        public static int LongestConsecutive1(Node root)
        {
            //return LongestConsecutiveHelper(root, null, 0);

           var longest= LongestConsecutiveHelper1(root);
            return longest;
        }

        public static int LongestConsecutiveHelper(Node root, Node Prev, int max)
        {
            if (root == null) return max;
            // at very first root.Data - Prev.Data != 1(no sequence) resets the count 1
            //else incremnet and pass down
            int maxVal = (Prev == null || root.Data - Prev.Data != 1) ? 1 : max + 1;

            var left = LongestConsecutiveHelper(root.Left, root, maxVal);
            var right = LongestConsecutiveHelper(root.Right, root, maxVal);
            //take max ( curmax, letmax and rightmax)
            return Math.Max(Math.Max(left, right), maxVal);
        }


        private static  int maxLength = 0;
        public static int LongestConsecutiveHelper1(Node root)
        {
            if (root== null) 
                return 0;

            int left = LongestConsecutiveHelper1(root.Left) + 1;

            int right = LongestConsecutiveHelper1(root.Right) + 1;

            if (root.Left != null && root.Data + 1 != root.Left.Data)
            {
                left = 1;
            }
            if (root.Right != null && root.Data + 1 != root.Right.Data)
            {
                right = 1;
            }
            int length = Math.Max(left, right);
            maxLength = Math.Max(maxLength, length);
            return length;

        }
    }
}

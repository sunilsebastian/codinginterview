using LinkedList.Common;
using System;

namespace LinkedList
{
    public class QueueHelper
    {
        public static LQueue Create(int[] values)
        {
            var q = new LQueue();
            for (int i = 0; i < values.Length; i++)
            {
                q.Enqueue(values[i]);
            }

            return q;
        }

        public static void PrintAll(LQueue q)
        {
            var node = q.Head;
            while (node != null)
            {
                Console.Write(node.Val + " ");
                node = node.Next;
            }
        }

        public static void PrintAll(Node n)
        {
            var node = n;
            while (node != null)
            {
                Console.Write(node.Val + " ");
                node = node.Next;
            }
        }

        public static void PopAll(LQueue q)
        {
            int num = q.Dequeue();
            while (num > 0)
            {
                Console.Write(num + " ");
                num = q.Dequeue();
            }
        }
    }
}
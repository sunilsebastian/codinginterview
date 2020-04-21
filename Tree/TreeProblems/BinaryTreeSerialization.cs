using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

//Time Complexity - O(n)， Space Compleixty - O(n)

namespace TreeProblems
{
    public class BinaryTreeSerialization
    {
        // Encodes a tree to a single string.
        public static string Serialize(Node root)
        {
            if (root == null)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();

            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root);
            while (queue.Count!=0)
            {
                Node t = queue.Dequeue();
                if (t != null)
                {
                    sb.Append(t.Data.ToString() + ",");
                    queue.Enqueue(t.Left);
                    queue.Enqueue(t.Right);
                }
                else
                {
                    sb.Append("#,");
                }
            }

            sb.Remove(sb.ToString().Length - 1,1);
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public Node deserialize(string data)
        {
            if (data == null || data.Length == 0)
                return null;

            String[] arr = data.Split(',');
            Node root = new Node(int.Parse(arr[0]));


            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            int i = 1;
            while (queue.Count!=0)
            {
                Node t = queue.Dequeue();

                if (t == null)
                    continue;

                if (!arr[i].Equals("#"))
                {
                    t.Left = new Node(int.Parse(arr[i]));
                    queue.Enqueue(t.Left);

                }
                else
                {
                    t.Left = null;
                    queue.Enqueue(null);
                }
                i++;

                if (!arr[i].Equals("#"))
                {
                    t.Right = new Node(int.Parse(arr[i]));
                    queue.Enqueue(t.Right);

                }
                else
                {
                    t.Right = null;
                    queue.Enqueue(null);
                }
                i++;
            }

            return root;
        }
    }
}

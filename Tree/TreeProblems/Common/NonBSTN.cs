using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems.Common
{
    public class NonBSTN
    {
        public NodeN Root { get; set; }

        public NonBSTN()
        {
            this.Root = null;
        }

        public void ClearAll()
        {
            this.Root = null;
        }

        public void InsertAll(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Insert(arr[i]);
            }

        }

        public void Insert(int data)
        {
            Queue<NodeN> q = new Queue<NodeN>();
            if (this.Root == null)
            {
                this.Root = new NodeN(data);
                return;
            }

            q.Enqueue(this.Root);

            while (q.Count() != 0)
            {
                NodeN n = q.Dequeue();


                if (n.Left == null)
                {
                    n.Left = new NodeN(data);
                    q.Clear();
                    break;
                }
                else if (n.Right == null)
                {
                    n.Right = new NodeN(data);
                    q.Clear();
                    break;
                }
                else
                {
                    q.Enqueue(n.Left);
                    q.Enqueue(n.Right);
                }
            }

        }


    }
}

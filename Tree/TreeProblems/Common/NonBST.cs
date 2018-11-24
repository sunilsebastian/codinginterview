using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems.Common
{
    public class NonBST
    {
        public Node Root { get; set; }

        public NonBST()
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
            Queue<Node> q = new Queue<Node>();
           if(this.Root==null)
            {
                this.Root = new Node(data);
                return;
            }

            q.Enqueue(this.Root);

            while(q.Count()!=0)
            {
                Node n = q.Dequeue();

                
                if(n.Left==null)
                {
                    n.Left = new Node(data);
                    q.Clear();
                    break;
                }
                else if(n.Right == null)
                {
                    n.Right = new Node(data);
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

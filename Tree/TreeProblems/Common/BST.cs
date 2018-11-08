using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems.Common
{
    public class BST
    {
        public Node Root { get; set; }

        public BST()
        {
            this.Root = null;
        }

        public void Insert(int data)
        {
            //this.Root = InSertHelper(this.Root, data);

            this.Root = InsertIterative(this.Root, data);
        }

        public Node InsertIterative(Node root, int data)
        {
            Node temp = null;
            

            if (root == null)
            {
                root = new Node(data);
                return root;
            }
            else
            {
                 temp = root;

                while (true)
                {
                    if (data < root.Data)
                    {
                        if (root.Left == null)
                        {
                            root.Left = new Node(data);
                            break;
                        }
                        else
                        {
                            root = root.Left;
                        }
                    }
                    else if(data > root.Data)
                    {
                        if (root.Right == null)
                        {
                            root.Right = new Node(data);
                            break;
                        }
                        else
                        {
                            root = root.Right;
                        }
                    }
                }
            }

            return temp;
        }

        private Node InSertHelper(Node root, int data)
        {
            if (root==null)
            {
                root= new Node(data);
                
            }
            else if(data < root.Data)
            {
                root.Left = InSertHelper(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InSertHelper(root.Right, data);
            }

            return root;

        }
    }
}

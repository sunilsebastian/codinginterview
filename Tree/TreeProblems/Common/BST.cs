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

        public void InsertAll(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                this.Root = InsertHelper(this.Root, arr[i]);
            }

        }

        public void ClearAll()
        {
            this.Root = null;
        }
        public void Insert(int data)
        {
            this.Root = InsertHelper(this.Root, data);

           // this.Root = InsertIterative(this.Root, data);
        }

        public void RemoveMin()
        {
            //this.Root = RemoveMinRecursive(this.Root);
            this.Root = RemoveMinIterative(this.Root); 
        }
        

        public void Remove(int x)
        {
            this.Root = Remove(x, this.Root);
        }

        public int FindMin()
        {
            return FindMin(this.Root).Data;
        }

        public int FindMax()
        {
            return FindMax(this.Root).Data;
        }

        public int Find(int x)
        {
            return Find(x, this.Root).Data;
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

        private Node InsertHelper(Node root, int data)
        {
            if (root==null)
            {
                root= new Node(data);
                
            }
            else if(data < root.Data)
            {
                root.Left = InsertHelper(root.Left, data);
            }
            else if (data > root.Data)
            {
                root.Right = InsertHelper(root.Right, data);
            }
            
            return root;

        }

        public static Node RemoveMinIterative(Node root)
        {

            if (root == null ||(root.Left==null && root.Right==null))
                return null;

            Node temp = root;
            Node parent = null;

            while(temp.Left!=null)
            {
                parent = temp;
                temp = temp.Left;
            }

             parent.Left = temp.Right;

             return root;
        }

        public static Node RemoveMinRecursive(Node root)
        {
            if (root.Left != null)
            {
              root.Left=  RemoveMinRecursive(root.Left);
            }
          
            else
            {
               root = root.Right;
            }
            return root;
        }

        private Node Find(int x, Node t)
        {
            while (t != null)
            {
                if ((x as IComparable).CompareTo(t.Data) < 0)
                {
                    t = t.Left;
                }
                else if ((x as IComparable).CompareTo(t.Data) > 0)
                {
                    t = t.Right;
                }
                else
                {
                    return t;
                }
            }

            return null;
        }
        public  Node Remove(int x, Node t)
        {
            if (t == null)
            {
                throw new Exception("Item not found");
            }
            else if (t.Data< x)  
            {
                t.Left = Remove(x, t.Left);
            }
            else if (t.Data > x)
            {
                t.Right = Remove(x, t.Right);
            }
            else if (t.Left != null && t.Right != null)
            {
                t.Data = FindMin(t.Right).Data;
                t.Right = RemoveMinRecursive(t.Right);
            }
            else
            {
                t = (t.Left != null) ? t.Left : t.Right;
            }

            return t;
        }

        private Node FindMin(Node t)
        {
            if (t != null)
            {
                while (t.Left != null)
                {
                    t = t.Left;
                }
            }

            return t;
        }

        private Node FindMax(Node t)
        {
            if (t != null)
            {
                while (t.Right != null)
                {
                    t = t.Right;
                }
            }

            return t;
        }
    }
}

   



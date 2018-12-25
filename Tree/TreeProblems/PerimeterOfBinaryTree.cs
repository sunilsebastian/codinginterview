using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class PerimeterOfBinaryTree
    {
        public static void PrintPerimeterOfaTree(Node root)
        {

            Node current = root;
            while (current != null)
            {
                if (current.Right != null && current.Left != null)
                {
                    current = current.Right;
                    break;
                }
                current = current.Left != null ? current.Left : current.Right;
            }
      
                PrintLeftBoundaryNodes(root);
                PrintLeafNodes(root);
                PrintRightBoundaryNodes(current);
   

        }
        private static void PrintLeftBoundaryNodes(Node root)
        {
            if (root == null)
                return;
            if(root.Left!=null)
            {
                Console.Write(root.Data + " ");
                PrintLeftBoundaryNodes(root.Left);
            }
            else if (root.Right != null)
            {
                Console.Write(root.Data + " ");
                PrintLeftBoundaryNodes(root.Right);
            }
        }

        private static void PrintRightBoundaryNodes(Node root)
        {
            if (root == null)
                return;

            if (root.Right != null)
            {
               
                PrintRightBoundaryNodes(root.Right);
                Console.Write(root.Data + " ");
            }
            else if (root.Left != null)
            {
               
                PrintRightBoundaryNodes(root.Left);
                Console.Write(root.Data + " ");
            }

        }

        private static void PrintLeafNodes(Node root)
        {
            if(root!=null)
            {
                if(root.Left==null && root.Right==null)
                    Console.Write(root.Data + " ");
                PrintLeafNodes(root.Left);
                PrintLeafNodes(root.Right);
            }

        }
    }

    
}

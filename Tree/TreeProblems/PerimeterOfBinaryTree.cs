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
            if (root != null)
            {
                PrintLeftBoundaryNodes(root);
                PrintLeafNodes(root);
                PrintRightBoundaryNodes(root);
            }

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
                Console.Write(root.Data + " ");
                PrintLeftBoundaryNodes(root.Right);
            }
            else if (root.Left != null)
            {
                Console.Write(root.Data + " ");
                PrintLeftBoundaryNodes(root.Left);
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

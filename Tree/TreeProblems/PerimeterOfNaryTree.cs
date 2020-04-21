using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class PerimeterOfNaryTree
    {
        public static void PrintPerimeterOfaTree(NAryTreeNode root)
        {

            NAryTreeNode current = root;
            while (current != null)
            {
                if (current.children.Count>0)
                {
                    current = current.children[current.children.Count - 1];
                    break;
                }
                current = current.children[0];
            }

            PrintLeftBoundaryNodes(root);
            PrintLeafNodes(root);
            PrintRightBoundaryNodes(current);


        }
        private static void PrintLeftBoundaryNodes(NAryTreeNode root)
        {
            if (root == null)
                return;
            Console.Write(root.Data + " ");
            if (root.children.Count>0)
            {
               
                PrintLeftBoundaryNodes(root.children[0]);
            }
           
        }

        private static void PrintRightBoundaryNodes(NAryTreeNode root)
        {
            if (root == null)
                return;
            if (root.children.Count > 0)
            {

                PrintLeftBoundaryNodes(root.children[root.children.Count - 1]);
            }
            Console.Write(root.Data + " ");

        }

        private static void PrintLeafNodes(NAryTreeNode root)
        {
            if (root == null) return;

            if (root.children.Count == 0)
                Console.Write(root.Data + " ");
            for (int i = 0; i < root.children.Count; i++)
            {
                PrintLeafNodes(root.children[i]);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Insert to a binary Tree
            BST bst = new BST();
            bst.Insert(20);
            bst.Insert(10);
            bst.Insert(8);
            bst.Insert(15);
            Console.WriteLine(bst.Root.ToString());

            //remove nodes out of boundary
            bst.ClearAll();
            int[] arr = new int[]{ 3, 0, 4, 2, 1 };
            bst.InsertAll(arr);
            TrimNodesOutisideBoundary.TrimBoundary(bst.Root, 1, 3);
            Console.WriteLine(bst.Root.ToString());

            //Remove minimum
            bst.ClearAll();
            arr = new int[]{ 3, 0, 4, 2, 1 };
            bst.InsertAll(arr);
            bst.RemoveMin();
            Console.WriteLine(bst.Root.ToString());

          


            //Get Max width of binary tree
            bst.ClearAll();
            arr =new int[] {30,40,50,20,10,8,15,25};
            bst.InsertAll(arr);
            int maxwidth= MaxWidthofTree.GetMaxWidth(bst.Root);
            Console.WriteLine($"Max width of Binary tree:{maxwidth}");


            //Get Max width of binary tree including null
            bst.ClearAll();
            arr = new int[] { 30, 40, 50,10,8};
            bst.InsertAll(arr);
            maxwidth =MaxWidthofTree.WidthOfBinaryTreewithNull(bst.Root);
            Console.WriteLine($"Max width of Binary tree with null:{maxwidth}");

            //check tree is Bst

            bst.ClearAll();
            arr = new int[] { 10, 5,2,7,20};
            bst.InsertAll(arr);
            bool isBst = CheckTreeIsBST.IsBsT(bst.Root,Int32.MinValue,Int32.MaxValue);

            Console.ReadLine();

        }
    }
}

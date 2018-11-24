﻿using System;
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
            Console.WriteLine($"check  [ 10,5,2,7,20]  is BST:{isBst}");

            bst.ClearAll();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);
            Console.Write("InOredr Traversal Iterative:");
            InOrderTraversal.Traverse(bst.Root);
            Console.WriteLine();

            //Level order traversdal  or Breadth First Traversal
            bst.ClearAll();
            arr = new int[] { 30,20,40,10,25};
            bst.InsertAll(arr);
            Console.Write("LevelOrder Traversal Iterative:");
            LevelOrderTraversal.Traverse(bst.Root);
            Console.WriteLine();

            //level order insert
            NonBST nonBst = new NonBST();
            arr = new int[] { 30,20,40,10,25,7,8,11,12};
            nonBst.InsertAll(arr);
            Console.Write("Non BST LevelOrder Traversal Iterative:");
            LevelOrderTraversal.Traverse(nonBst.Root);
            Console.WriteLine();

            //check Two Trees are equal

            bst = new BST();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);

            var bst1 = new BST();
            var arr11 = new int[] { 30, 40, 50, 22, 10, 8, 15, 25 };
            bst1.InsertAll(arr11);

            bool isEqual=SameTree.IsSameTree(bst.Root, bst1.Root);

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}

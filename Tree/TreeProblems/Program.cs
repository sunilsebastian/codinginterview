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
            NonBST nonBst = new NonBST();
            var testArr = new int[] {4,2,5,1,3 };
            nonBst.InsertAll(testArr);
            var dlist=TreeToDoubleList.BTtoLL(nonBst.Root);

            Node tnode = new Node(1);
            tnode.Left = new Node(2);
            tnode.Right = new Node(3);
            tnode.Left.Left = new Node(4);
            tnode.Left.Right = new Node(5);
            tnode.Left.Left.Left = new Node(6);
            tnode.Left.Left.Right = new Node(7);

            FlipTreeUpDown.FlipUpsideDown(tnode);


            BstFromPostOrder.BstFrmPostOrder(new int[] { 8, 6, 12, 9 });

            NAryTreeNode nAryNode = HeightOfNaryTree.Create();
            var nAryTreeHeight=HeightOfNaryTree.GetHeight(nAryNode);

            //for (int i = 1; i <20; i++)
            //{
            //    Console.Write($"{UniqueBSTCount.GetUniqueBSTCount(i)} ");
            //}

            
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
            //arr = new int[] { 30, 40, 50,10,8};
            //arr = new int[] { 30, 40, 35,10,12};
            arr = new int[] { 10, 20, 30,5,8};
            bst.InsertAll(arr);
          

            //check tree is Bst

            bst.ClearAll();
            arr = new int[] { 10, 5,2,7,20};
            bst.InsertAll(arr);
            bool isBst = CheckTreeIsBST.IsBsT(bst.Root,Int32.MinValue,Int32.MaxValue);
            Console.WriteLine($"check  [ 10,5,2,7,20]  is BST:{isBst}");

            //InOrder
            bst.ClearAll();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);
            Console.Write("InOredr Traversal Iterative:");
            InOrderTraversal.Traverse(bst.Root);
            Console.WriteLine();
            
            //Post order
            bst.ClearAll();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);
            Console.Write("PostOrder Traversal Iterative:");
            PostOrderTraversal.Traverse(bst.Root);
            Console.WriteLine();

            //Pre order
            bst.ClearAll();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);
            Console.Write("PreOrder Traversal Iterative:");
            PreOrderTraversal.Traverse(bst.Root);
            Console.WriteLine();

            //Level order traversdal  or Breadth First Traversal
            bst.ClearAll();
            arr = new int[] { 30,20,40,10,25};
            bst.InsertAll(arr);
            Console.Write("LevelOrder Traversal Iterative:");
            LevelOrderTraversal.Traverse(bst.Root);
            Console.WriteLine();

            //Level order traversdal  new line
            bst.ClearAll();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);
            Console.WriteLine("LevelOrder Traversal Iterative Newline:");
            LevelOrderNewLine.Traverse(bst.Root);
            Console.WriteLine();

            NonBSTN nonBst1 = new NonBSTN();
            arr = new int[] { 1,2,3,4,5,6,7};
            nonBst1.InsertAll(arr);
            Console.WriteLine("LevelOrder with Next pointer:");
            ConnectNodesAtSameLevel.ConnectNextpointer(nonBst1.Root);
            Console.WriteLine();

            //Level order Traversal  Reverse
            bst.ClearAll();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);
            Console.Write("LevelOrder Traversal Reverse:");
            LevelorderReverse.Traverse(bst.Root);
            Console.WriteLine();

            //Spiral order Traversal  Reverse
             nonBst = new NonBST();
            arr = new int[] { 10, 16, 5, 2, 3, 6, 11 };
            nonBst.InsertAll(arr);
            Console.Write("Spiral Order Traversal Reverse:");
            SpiralOrderTraversal.Traverse(nonBst.Root);
            Console.WriteLine();

            //level order insert
            nonBst = new NonBST();
            arr = new int[] { 30,20,40,10,25,7,8,11,12};
            nonBst.InsertAll(arr);
            Console.Write("Non BST LevelOrder Traversal Iterative:");
            LevelOrderTraversal.Traverse(nonBst.Root);
            Console.WriteLine();

            //Check Two Trees are equal

            bst = new BST();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);

            var bst1 = new BST();
            var arr11 = new int[] { 30, 40, 50, 22, 10, 8, 15, 25 };
            bst1.InsertAll(arr11);
            bool isEqual=SameTree.IsSameTree(bst.Root, bst1.Root);

            //Root to Leafpath
            nonBst.ClearAll();
            arr = new int[] { 10,16,5,2,3,6,11};
            nonBst.InsertAll(arr);
            RootToLeafSum.FindRootToLeafPath(nonBst.Root, 26);
            Console.WriteLine();


            PreOrderArrayToTree b = new PreOrderArrayToTree();
            b.BuildTree(new int[] { 10, 30, 20, 5, 15 }, new char[] { 'N', 'N', 'L', 'L', 'L' });
            Console.Write("BuildTree PreOrder Traversal for [10, 30, 20, 5, 15]:");
            PreOrderTraversal.Traverse(b.Root);
            Console.WriteLine();

            BinaryTreeFromPreOrderInOrder bld = new BinaryTreeFromPreOrderInOrder();
            bld.BuildTree(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2,1,4,3,5});

            Node tree= BinaryTreeFromPostOrderInOrder.BuildTree(new int[] { 4, 2, 7, 8, 5, 6, 3, 1 }, new int[] { 4, 2, 1, 7, 5, 8, 3, 6 });
            PreOrderTraversal.Traverse(tree);
            Console.WriteLine();


            nonBst = new NonBST();
            arr = new int[] { 25,18,50,19,20,35,60 };
            nonBst.InsertAll(arr);
            int size=LargestBSTInBinaryTree.FindLargestBinarySearchTreeSize(nonBst.Root);
            Console.Write($"Max BST size in BT [25,18,50,19,20,35,60] is :{size}");
            Console.WriteLine();

            nonBst = new NonBST();
            arr = new int[] {10,5,30,3,7,15,35};
            nonBst.InsertAll(arr);
            var miirorTree = MirrorOfBinaryTree.MirrorTree(nonBst.Root);
            LevelOrderTraversal.Traverse(miirorTree);
            Console.WriteLine();

            nonBst = new NonBST();
            arr = new int[] { 10, 5, 30, 3, 7, 15, 35 };
            nonBst.InsertAll(arr);
            Node n= LowestCommonAncesterBinaryTree.FindLeastCommonAncester(nonBst.Root, 15, 3);
            Console.Write($"Lowest Common ancester of [15,3] in BT [25,18,50,19,20,35,60] is :{n.Data}");
            Console.WriteLine();

            nonBst = new NonBST();
            arr = new int[] { 10,20, 30,40, 50, 60, 70 };
            nonBst.InsertAll(arr);
            InorderSuccessor.InOrderSuccessorOfBinaryTree(nonBst.Root, 50);

            bst.ClearAll();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25 };
            bst.InsertAll(arr);
            n=LowestCommonAncestorBST.FindLeastCommonAncester(bst.Root,15,25);
            Console.Write($"Lowest Common ancester of [15,25] in BST [30, 40, 50, 20, 10, 8, 15, 25] is :{n.Data}");
            Console.WriteLine();

            bst.ClearAll();
            arr = new int[] { 30, 40, 50, 20, 10, 8, 15, 25,11,16 };
            bst.InsertAll(arr);
            Console.Write("Perimeter of a Binary Tree { 30, 40, 50, 20, 10, 8, 15, 25,11,16} is : ");
            PerimeterOfBinaryTree.PrintPerimeterOfaTree(bst.Root);
            Console.WriteLine();

            nonBst = new NonBST();
            arr = new int[] { 10, 5, 30, 3, 7, 15, 35 };
            nonBst.InsertAll(arr);
            Console.WriteLine("Convrted array of  of a Binary Tree { 10, 5, 30, 3, 7, 15, 35 } is : ");
            TreeTo2DMatrix.ConvertTreeToMatrix(nonBst.Root);
            Console.WriteLine();

            n =ArrayMaxRootTree.BuildTree(new int[] { 3, 2,1, 6, 0, 5 });
            Console.Write("MaxTop BuildTree PreOrder Traversal for  3, 2, 1, 6, 0, 5]:");
            LevelOrderTraversal.Traverse(n);
            Console.WriteLine();

            nonBst = new NonBST();
            arr = new int[] { 50, 6, 2, 10, 13 ,20, 15 };
            nonBst.InsertAll(arr);
            MinimumSumLevel.FindMinimumSumLevel(nonBst.Root);
            Console.WriteLine();

            nonBst = new NonBST();
            arr = new int[] { 1,2,3,4,5 };
            nonBst.InsertAll(arr);
            DiameterOfBinaryTree.GetDiameterOfBinaryTree(nonBst.Root);


            nonBst = new NonBST();
            arr = new int[] {10,20,30,40,6 };
            nonBst.InsertAll(arr);
            Console.Write("Ancestors of 6 in BT {10,20,30,40,6 }:");
            AncestersOfAGivenNode.PrintAncestors(nonBst.Root,6);
            Console.WriteLine();


            ConstructAllBST.GetBSTList(2);


            nonBst = new NonBST();
            arr = new int[] {1,2,4,3,9,5,6};
            nonBst.InsertAll(arr);
            var mxCount= BSTLongestConsecutiveSequence.LongestConsecutive(nonBst.Root);
            var mmxCount = BSTLongestConsecutiveSequence.LongestConsecutive1(nonBst.Root);

            KDistancefromTarget.DistanceK(nonBst.Root,3,2);

            var serializedString =  BinaryTreeSerialization.Serialize(nonBst.Root);

            var rviewList=RightView.RightSideView(nonBst.Root);

            LNode ln = new LNode(1);
            ln.Next = new LNode(2);
            ln.Next.Next = new LNode(3);
            ln.Next.Next.Next = new LNode(4);
            ln.Next.Next.Next.Next = new LNode(5);
            ln.Next.Next.Next.Next.Next = new LNode(6);

            Node lstTree= SortedListToTree.SortedListToBST(ln);

            Console.Write("vertical print of  in BT {1,2,4,3,9,5,6 }:");
            VerticalOrder.PrintVerticalOrder(nonBst.Root);
          


            var bstOne = new BST();
            var arrOne = new int[] {2,1,3 };
            bstOne.InsertAll(arrOne);

            var bstTwo = new BST();
            var arrTwo = new int[] {7,6,8 };
            bstTwo.InsertAll(arrTwo);
            MergeBST.mergeTwoBSTs(bstOne.Root, bstTwo.Root);

        

            nonBst = new NonBST();
            arr = new int[] {-10,5,8,2,12};
            nonBst.InsertAll(arr);
            MaxPathSum.GetMaxPathSum(nonBst.Root);

            nonBst = new NonBST();
            arr = new int[] { 1, 2, };
            nonBst.InsertAll(arr);
            CousinsBT.IsCousins(nonBst.Root, 1,3);

            nonBst = new NonBST();
            nonBst.Root = new Node(1);
            nonBst.Root.Left = new Node(3);
            nonBst.Root.Right = new Node(2);
            nonBst.Root.Left.Left = new Node(5);
            nonBst.Root.Right.Right = new Node(9);


            maxwidth = MaxWidthofTree.WidthOfBinaryTreewithNull(nonBst.Root);
            Console.WriteLine($"Max width of Binary tree with null:{maxwidth}");

            Console.ReadLine();





        }
    }
}

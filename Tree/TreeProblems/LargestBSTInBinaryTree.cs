using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public  class LargestBSTInBinaryTree
    {
        public static int FindLargestBinarySearchTreeSize(Node root)
        {
            var minmax = FindLargestBinarySearchTreeSizeHelper(root);
            return minmax.Size;
        }

        public static MinMax FindLargestBinarySearchTreeSizeHelper(Node root)
        {
            if(root==null)
            {
                return new MinMax();
            }

            MinMax leftMinMax = FindLargestBinarySearchTreeSizeHelper(root.Left);
            MinMax rightMinMax = FindLargestBinarySearchTreeSizeHelper(root.Right);

            var minMax = new MinMax();

            if(leftMinMax.isBST==false || rightMinMax.isBST==false || leftMinMax.Max>root.Data || rightMinMax.Min<root.Data)
            {
                minMax.Size = Math.Max(leftMinMax.Size, rightMinMax.Size);
                minMax.isBST = false; ;
                return minMax;
            }

            minMax.isBST = true;
            minMax.Min = (root.Left != null) ? leftMinMax.Min : root.Data;
            minMax.Max = (root.Right != null) ? rightMinMax.Max : root.Data;
            minMax.Size = leftMinMax.Size + rightMinMax.Size + 1;
            return minMax;


        }




    }

    public class MinMax
    {
        public int Size { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public bool isBST { get; set; }

        public MinMax()
        {
            Size = 0;
            Min = Int32.MaxValue;
            Max = Int32.MinValue;
            isBST = true;
         

        }
    }
}

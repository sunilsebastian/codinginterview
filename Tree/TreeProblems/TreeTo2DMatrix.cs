using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class TreeTo2DMatrix
    {
      
        public static void ConvertTreeToMatrix(Node root)
        {
            int  h = HeightOfBinaryTree.GetHeight(root);
            int column = (int)Math.Pow(2, h) - 1;
            int[,] arr = new int[h,column];

            ConvertTreeToMatrixHelper(root, arr, 0, arr.GetLength(1) - 1, 0);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }


        }

        public static void ConvertTreeToMatrixHelper(Node root, int[,] arr, int left,int right,int level)
        {
            if (root == null) return;
            if(left<=right)
            {
                int mid = (left + right) / 2;
                arr[level, mid] = root.Data;
                ConvertTreeToMatrixHelper(root.Left, arr, left, mid - 1, level + 1);
                ConvertTreeToMatrixHelper(root.Right, arr,mid+1,right, level + 1);

            }
        }
    }
}
 
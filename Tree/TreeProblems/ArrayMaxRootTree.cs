using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class ArrayMaxRootTree
    {
        //Worst Case O(n2}  
        public static Node BuildTree(int[] arr)
        {
            return BuildTreeHelper(arr, 0, arr.Length - 1);
        }

        private static Node BuildTreeHelper(int[] arr, int left, int right)
        {
            if (left > right)
                return null;
            int maxIndex = FindMax(arr, left, right);
            Node n = new Node(arr[maxIndex]);
            n.Left = BuildTreeHelper(arr, left, maxIndex - 1);
            n.Right = BuildTreeHelper(arr, maxIndex + 1, right);
            return n;
        }

        private static int FindMax(int[] arr, int left, int right)
        {
            int max = left;
            for (int i = left; i <= right; i++)
            {
                if (arr[max] < arr[i])
                    max = i;
            }
            return max;
        }
    }
}

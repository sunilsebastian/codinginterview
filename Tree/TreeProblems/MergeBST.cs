using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class MergeBST
    {
        public static Node mergeTwoBSTs(Node root1, Node root2)
        {

            if (root1 == null)
                return root2;
            if (root2 == null)
                return root1;

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            TraverseInOrder(root1, list1);
            TraverseInOrder(root2, list2);

            int[] mergedArray = Merge(list1, list2);

            return BuildTree(mergedArray, 0, mergedArray.Length - 1);
        }


        public static void TraverseInOrder(Node root, List<int> lst)
        {
            if (root == null)
                return;

            TraverseInOrder(root.Left, lst);
            lst.Add(root.Data);
            TraverseInOrder(root.Right, lst);
        }

        public static int[] Merge(List<int> list1, List<int> list2)
        {
            int[] arr1 = list1.ToArray();
            int[] arr2 = list2.ToArray();

            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                    result[k++] = arr1[i++];
                else
                    result[k++] = arr2[j++];
            }
            while (i < arr1.Length) { result[k++] = arr1[i++]; }
            while (j < arr2.Length) { result[k++] = arr2[j++]; }

            return result;
        }

        public static Node BuildTree(int[] mergedArray, int start, int end)
        {
            if (start > end)
                return null;
            int mid = start + (end-start) / 2;

            Node n = new Node(mergedArray[mid]);
            n.Left = BuildTree(mergedArray, start, mid - 1);
            n.Right = BuildTree(mergedArray, mid + 1, end);

            return n;
        }
    }
}

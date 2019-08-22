using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class UnivalTree
    {
     
        public static int FindSingleValueTrees(Node root)
        {

            UniVal unival = new UniVal();
            SingleValueTreeHelper(root, unival);

            return unival.Count;


        }

        public static bool SingleValueTreeHelper(Node root, UniVal unival)
        {
            if (root == null)
                return true;

            var left = SingleValueTreeHelper(root.Left, unival);
            var right = SingleValueTreeHelper(root.Right, unival);

            if (left == false || right == false)
                return false;

            if (root.Left != null && root.Left.Data != root.Data)
                return false;

            if (root.Right != null && root.Right.Data != root.Data)
                return false;

            unival.Count++;

            return true;
        }

        public class UniVal
        {
            public int Count { get; set; }
        }

    }
}

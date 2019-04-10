using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class SortedArrayToBST
    {
        public Node sortedArrayToBST(int[] num)
        {
            if (num.Length == 0)
                return null;

            return sortedArrayToBST(num, 0, num.Length - 1);
        }

        public Node sortedArrayToBST(int[] num, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            Node root = new Node(num[mid]);
            root.Left = sortedArrayToBST(num, start, mid - 1);
            root.Right = sortedArrayToBST(num, mid + 1, end);

            return root;
        }

    }
}

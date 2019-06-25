using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class RightView
    {
        public static IList<int> RightSideView(Node root)
        {

            List<int> list = new List<int>();
            if (root == null) return list;
            int depth = 1;
            findMaxDepthElements(list, root, depth);
            return list;
        }

        private static void findMaxDepthElements(List<int> list, Node root, int depth)
        {

            if (list.Count < depth)
                list.Add(root.Data);

            if (root.Right != null)
                findMaxDepthElements(list, root.Right, depth + 1);

            if (root.Left != null)
                findMaxDepthElements(list, root.Left, depth + 1);

        }
    }
}

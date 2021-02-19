using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{

//Input: [1,2,3,null,5,null,4]
//Output: [1, 3, 4]
//Explanation:

//   1            <---
// /   \
//2     3         <---
// \     \
//  5     4       <---
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

        public IList<int> RightSideView1(Node root)
        {

            List<int> lst = new List<int>();
            if (root == null)
                return lst;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count() != 0)
            {
                int size = q.Count();

                for (int i = 0; i < size; i++)
                {
                    var n = q.Dequeue();

                    if (i == size - 1)
                        lst.Add(n.Data);

                    if (n.Left != null)
                        q.Enqueue(n.Left);
                    if (n.Right != null)
                        q.Enqueue(n.Right);
                }

            }

            return lst;

        }
    }
}

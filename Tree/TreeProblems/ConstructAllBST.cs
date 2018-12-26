using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class ConstructAllBST
    {
        public static void GetBSTList(int n)
        {
            var list = ConstructTrees(1, n);
        }
        private static List<Node> ConstructTrees(int start, int end)
        {
            List<Node> list = new List<Node>();

           
            if (start > end)
            {
                list.Add(null);
                return list;
            }

            /*  iterating through all values from start to end  for constructing\ 
            left and right subtree recursively  */
            for (int i = start; i <= end; i++)
            {
                /*  constructing left subtree   */
                List<Node> leftSubtree = ConstructTrees(start, i - 1);

                /*  constructing right subtree  */
                List<Node> rightSubtree = ConstructTrees(i + 1, end);

                /*  now looping through all left and right subtrees and connecting 
                    them to ith root  below  */
                for (int j = 0; j < leftSubtree.Count(); j++)
                {
                    Node left = leftSubtree[j];
                    for (int k = 0; k < rightSubtree.Count(); k++)
                    {
                        Node right = rightSubtree[k];
                        Node node = new Node(i);
                        node.Left = left;   
                        node.Right = right;
                        list.Add(node);
                    }
                }
            }
            return list;
        }
    }
}

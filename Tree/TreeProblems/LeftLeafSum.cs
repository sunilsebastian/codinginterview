using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class LeftLeafSum
    {
        public int SumOfLeftLeaves(Node root)
        {
            if (root == null) return 0;
            int ans = 0;
            if (root.Left != null)
            {
                if (root.Left.Left == null && root.Left.Right == null)
                    ans += root.Left.Data;
                else
                    ans += SumOfLeftLeaves(root.Left);
            }
            ans += SumOfLeftLeaves(root.Right);

            return ans;
        }
        

        public int SumOfLeftLeavesIterative(Node root)
        {
            if (root == null) return 0;
            int ans = 0;
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count>0)
            {
                Node node = stack.Pop();
                if (node.Left != null)
                {
                    if (node.Left.Left == null && node.Left.Right == null)
                        ans += node.Left.Data;
                    else
                        stack.Push(node.Left);
                }
                if (node.Right != null)
                {
                    if (node.Right.Left != null || node.Right.Right != null)
                        stack.Push(node.Right);
                }
            }
            return ans;
        }
    }
}

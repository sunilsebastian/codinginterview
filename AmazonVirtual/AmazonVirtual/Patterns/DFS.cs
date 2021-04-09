using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class DFS
    {
        //preorder is DFS

        //Divide and conquor
        //each node find max of left sub tree and find the 
        //max(root.val,leftMax,rightMax)
        public static int FindMax(TreeNode root)
        {
            if (root == null) 
                return Int32.MinValue;
            var left = FindMax(root.left);
            var right = FindMax(root.right);

            return Math.Max(Math.Max(left, right), root.val);

        }

       
        //Global variable versus  local variable
        static int treeMaxValue = Int32.MinValue;
        public static void FindMax1(TreeNode root)
        {
            if (root == null)
                return ;

            treeMaxValue = Math.Max(treeMaxValue, root.val);

             FindMax1(root.left);
            FindMax1(root.right);

        }

        public int GetVisibleTreeNode(TreeNode root,int maxSofar)
        {
            int count = 0;
            if (root == null)
                return 0;
            if (root.val > maxSofar) count++;

            count+=GetVisibleTreeNode(root.left, Math.Max(root.val, maxSofar));
            count+= GetVisibleTreeNode(root.right, Math.Max(root.val, maxSofar));
            return count;
        }

    }
}

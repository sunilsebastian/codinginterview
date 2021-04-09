using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    //https://www.geeksforgeeks.org/print-bst-keys-in-the-given-range/
    public class PrintBSTInRange
    {
        // k1=10 k2=25
        //treee

        public static  List<int> GetBstKeysInRange()
        {
            int k1 = 10, k2 = 25;

            TreeNode root = new TreeNode(20);
            root.left = new TreeNode(8);
            root.right = new TreeNode(22);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(12);

            List<int> result = new List<int>();

            GetBstKeysInRange(root, result, k1, k2);
            return result;
        }

        public static void  GetBstKeysInRange(TreeNode root, List<int> result,int k1, int k2)
        {
            if (root == null)
                return;
            if (root.val>k1)
                GetBstKeysInRange(root.left, result, k1, k2);
            if (root.val >= k1 && root.val <= k2)
                result.Add(root.val);
            if(root.val<k2)
                GetBstKeysInRange(root.right, result, k1, k2);
        }
    }
}

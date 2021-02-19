using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class PathSum_III
    {
        int count = 0;
        int k;
        Dictionary<int, int> dict = new Dictionary<int, int>();

        public void preorder(Node node, int sum)
        {
            if (node == null)
                return;

            sum += node.Data;

            if (sum == k)
                count++;
            if (dict.ContainsKey(sum - k))
            {
                count = count + dict[sum - k];
            }

            if (!dict.ContainsKey(sum))
            {
                dict.Add(sum, 1);
            }
            else
            {
                dict[sum]++;
            }


            preorder(node.Left, sum);
            // process right subtree
            preorder(node.Right, sum);

            //backtrack and remove the items
            if (dict[sum] == 1)
                dict.Remove(sum);
            else
                dict[sum]--;
        }

        public int PathSum(Node root, int sum)
        {
            k = sum;
            preorder(root, 0);
            return count;
        }
    }
}

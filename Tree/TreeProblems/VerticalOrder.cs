using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class VerticalOrder
    {
        public static void GetVerticalOrder(Node root, int hd,
                                Dictionary<int, List<int>> dict)
        {
            // Base case 
            if (root == null)
                return;

            if(!dict.ContainsKey(hd))
            {
                dict.Add(hd, new List<int>());
            }
            dict[hd].Add(root.Data);

            // Store nodes in left subtree 
            GetVerticalOrder(root.Left, hd - 1, dict);

            // Store nodes in right subtree 
            GetVerticalOrder(root.Right, hd + 1, dict);
        }

        // The main function to print vertical oder of a binary tree 
        // with given root 
        public  static void PrintVerticalOrder(Node root)
        {
            // Create a map and store vertical oder in map using 
            // function getVerticalOrder() 
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int hd = 0;
            GetVerticalOrder(root, hd, dict);

            // Traverse the map and print nodes at every horizontal 
            // distance (hd) 
            foreach( var lst in dict.OrderBy(_=>_.Key))
            {
                Console.WriteLine(string.Join(", ", lst.Value));
            }

        }
    }
}

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

        public static List<Node> GetBSTList(int n)
        {
            if (n == 0)
            {
                return new List<Node>();
            }

          var result = helper(1, n);
            return result;
        }

        public static List<Node> helper(int start, int end)
        {
            List<Node> result = new List<Node>();
            if (start > end)
            {
                result.Add(null);
                return result;
            }

            for (int i = start; i <= end; i++)
            {
                List<Node> ls = helper(start, i - 1);
                List<Node> rs = helper(i + 1, end);
                foreach(var lsnode in ls)
                {
                    foreach (var rsnode in rs)
                    {
                        Node curr = new Node(i);
                        curr.Left = lsnode;
                        curr.Right = rsnode;
                        result.Add(curr);
                    }
                }
            }

            return result;
        }
    }
}

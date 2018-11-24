 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    class RootToLeafSum
    {
        public static void  FindRootToLeafPath(Node root, int sum)
        {
            List<int> lst = new List<int>();
            var isPath = FindRootToLeafPathHelper(root, sum, lst);

            Console.WriteLine($"Is there a path sum to {sum}: {isPath}");
            Console.Write("Path:");
           foreach (var l in lst)
           {
                Console.Write(l + "<-");
           }

        }

        private static bool FindRootToLeafPathHelper(Node root, int sum, List<int> lst)
        {

            if(root == null)
                return false;
            //if its a leaf node it should be 
            if(root.Left==null && root.Right==null)
            {
                if (root.Data == sum)
                {
                    lst.Add(root.Data);
                    return true;
                }
                else return false;
            }

            var leftResult = FindRootToLeafPathHelper(root.Left, sum - root.Data, lst);
            if(leftResult==true)
            {
                lst.Add(root.Data);
                return true;
            }

            var rightResult = FindRootToLeafPathHelper(root.Right, sum - root.Data, lst);
            if (rightResult == true)
            {
                lst.Add(root.Data);
                return true;
            }

            return false;


        }
    }
}

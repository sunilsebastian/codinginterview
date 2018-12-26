using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class AncestersOfAGivenNode
    {
        public static void PrintAncestors(Node root, int data)
        {
            List<int> lst = new List<int>();

            PrintAncestors(root, data, lst);

            foreach(int val in lst)
            {
                Console.Write(val + " ");
            }

        }

        private static bool PrintAncestors(Node root, int data, List<int> lst)
        {
            if (root == null)
                return false;

            if (root.Data == data)
                return true;

            var left = PrintAncestors(root.Left, data, lst);
            if(left==true)
            {
                lst.Add(root.Data);
                return left;

            }

            var right = PrintAncestors(root.Right, data, lst);
            if (right == true)
            {
                lst.Add(root.Data);
                return right;

            }

            return false;


        }
    }
}

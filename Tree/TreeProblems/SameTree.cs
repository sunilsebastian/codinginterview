using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class SameTree
    {

        public static bool IsSameTree(Node n1, Node n2)
        {
            if (n1 == null && n2 == null)
                return true;

            if (n1 == null || n2 == null)

                return false;

            if (n1.Data != n2.Data)
                return false;

            var leftStatus = IsSameTree(n1.Left, n2.Left);
            if (leftStatus == false)
                return false;

            var rightStatus = IsSameTree(n1.Right, n2.Right);

            if (rightStatus == false)
                return false;

            return true;


        }
    }
}

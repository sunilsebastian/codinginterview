using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
   public  class CheckTreeIsBST
    {
        public static  bool IsBsT(Node root,int min,int max)
        {

            if (root == null)
                return true;
            if(root.Data<min || root.Data>max)
            {
                return false;
            }

           var lesftBst= IsBsT(root.Left, min, root.Data);
           var rightBst = IsBsT(root.Right, root.Data,max);

            return lesftBst && rightBst;
        }
    }
}

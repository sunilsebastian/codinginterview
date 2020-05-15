using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class ValidSequenceRootLeavesPath
    {
        //Tree:[0,1,0,0,1,0,null,null,1,0,0]
        //Arr:[0,1,0,1]
        //Ans:True

        //[0,1,0,0,1,0,null,null,1,0,0]
        //[0,0,1]
        //Ans:False

        //[0,1,0,0,1,0,null,null,1,0,0]
        //[0,1,1]
        //Ans:False

        //[8,3,null,2,1,5,4]
        //[8]
        //Ans:false

        //[8,null,3,2]
        //[8,3]
        //Ans:false
        public static  bool IsValidSequence(Node root, int[] arr)
        {

            return TraverseHelper(root, arr, 0);

        }

        public static  bool TraverseHelper(Node root, int[] arr, int index)
        {
            if (root == null) return false;

            if (index > arr.Length - 1)
                return false;

            if (root.Data != arr[index]) return false;

            if (root.Left == null && root.Right == null)
            {
                if (index < arr.Length - 1)
                    return false;

                if (root.Data == arr[index])
                    return true;
            }

            return TraverseHelper(root.Left, arr, index + 1) || TraverseHelper(root.Right, arr, index + 1);

        }
    }
}

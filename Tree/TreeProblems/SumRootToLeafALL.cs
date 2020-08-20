using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class SumRootToLeafALL
    {
      
        public int SumNumbers(Node root)
        {
            Counter counter = new Counter();
            preorder(root, 0, counter);
            return counter.val;
        }
        public void preorder(Node r, int currNumber, Counter counter)
        {
            if (r == null)
                return;

            // if it's a leaf, update root-to-leaf sum
            if (r.Left == null && r.Right == null)
            {
                currNumber = currNumber * 10 + r.Data;
                counter.val += currNumber;
                return;
            }

            currNumber = currNumber * 10 + r.Data;
            preorder(r.Left, currNumber, counter);
            preorder(r.Right, currNumber, counter);
        }

        public int SumNumbers1(Node root)
        {
            if (root == null) return 0;

            StringBuilder sb = new StringBuilder();
            Counter counter = new Counter();
            SumNumberHelper(root, sb, counter);
            return counter.val;
        }

        public void SumNumberHelper(Node root, StringBuilder sb, Counter counter)
        {
            if (root == null) return;
            if (root.Left == null && root.Right == null)
            {
                sb.Append(root.Data);
                counter.val = counter.val + Int32.Parse(sb.ToString());
                sb.Remove(sb.Length - 1, 1);
                return;
            }

            sb.Append(root.Data);
            SumNumberHelper(root.Left, sb, counter);

            SumNumberHelper(root.Right, sb, counter);
            sb.Remove(sb.Length - 1, 1);
        }

    }
    public class Counter
    {
        public int val { get; set; }
    }
}

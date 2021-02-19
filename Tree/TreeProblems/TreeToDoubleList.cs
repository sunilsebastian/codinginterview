using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public class TreeToDoubleList
    {
        public static Node BTtoLL(Node root)
        {
            Node prev = null;
            Node head = null;
            if (root == null)
                return null;
            BTtoLLHelper(root, ref prev, ref head);

            //this is to make circular;
            head.Left = prev;
            prev.Right = head;
            return head;
        }

       public  static void BTtoLLHelper(Node root, ref Node prev, ref Node head)
        {
            if (root == null)
                return;

            BTtoLLHelper(root.Left, ref prev, ref head);

            if (prev != null)
            {
                root.Left = prev;
                prev.Right = root;
            }
            else
                head = root;

            prev = root;

            BTtoLLHelper(root.Right, ref prev, ref head);
        }
    }
}

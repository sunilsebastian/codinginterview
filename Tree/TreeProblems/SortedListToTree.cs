using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeProblems.Common;

namespace TreeProblems
{
    public  class SortedListToTree
    {
        private static  LNode node;

        public static  Node SortedListToBST(LNode head)
        {
            if (head == null)
            {
                return null;
            }

            int size = 0;
            LNode runner = head;
            node = head;

            while (runner != null)
            {
                runner = runner.Next;
                size++;
            }

            return inorderHelper(0, size - 1);
        }

        public static  Node inorderHelper(int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = start + (end - start) / 2;
            Node left = inorderHelper(start, mid - 1);

            Node treenode = new Node(node.Val);
            treenode.Left = left;
            node = node.Next;

            Node right = inorderHelper(mid + 1, end);
            treenode.Right = right;

            return treenode;
        }
    }

    public class LNode
    {
        public int Val { get; set; }

        public LNode Next { get; set; }

        public LNode(int val)
        {
            this.Val = val;
        }
    }
}

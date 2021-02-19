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
        public static  Node SortedListToBST(LNode head)
        {
            if (head == null)
                return null;
            LNode mid = GetMid(head);
            Node root = new Node(mid.Val);
            if (head == mid)
                return root;

            root.Left = SortedListToBST(head);
            root.Right = SortedListToBST(mid.Next);
            return root;
        }

        public static  LNode GetMid(LNode head)
        {
            LNode fast = head;
            LNode slow = head;
            LNode prev = head;
            while(fast!=null && fast.Next!=null)
            {
                prev = slow;
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            if (prev != null)
                prev.Next = null;
            return slow;
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

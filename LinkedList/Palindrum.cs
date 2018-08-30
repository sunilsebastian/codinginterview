using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CNode
    {
        public Char Val { get; set; }

        public CNode Next { get; set; }

        public CNode(Char val)
        {
            this.Val = val;
        }
    }

    public class CStack
    {
        public CNode Head = null;

        public CNode CreateNode(Char val)
        {
            return new CNode(val);
        }

        public void Push(Char val)
        {
            if (Head == null)
            {
                Head = CreateNode(val);
            }
            else
            {
                CNode n = CreateNode(val);
                n.Next = Head;
                Head = n;
            }
        }
    }

    public class Palindrum
    {
        public  CNode Create(string s)
        {
            CStack stk = new CStack();

            foreach(char c in s)
            {
                stk.Push(c);

            }
            return stk.Head;

        }

        public bool Check(string s)
        {
            bool isPalindrum = true; ;
            Stack<char> stk = new Stack<char>();
            CNode start = Create(s);

            CNode slow = start;
            CNode fast = start;

            while(fast!=null && fast.Next!=null)
            {
                stk.Push(slow.Val);
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            if(fast!=null)
            {
                slow = slow.Next;
            }

            while(slow!=null)
            {
                char c=stk.Pop();
                if(!char.Equals(c,slow.Val))
                {
                    isPalindrum = false;
                    break;
                }
                slow = slow.Next;
            }
            return isPalindrum;
        }
    }
}

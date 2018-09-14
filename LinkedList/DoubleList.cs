using LinkedList.Common;
using System;

namespace LinkedList
{
    public class DoubleList
    {
        public DoubleNode Head = null;

        public Node CreateNode(int val)
        {
            return new Node(val);
        }

        public void InsertNode(int val)
        {
            DoubleNode n = new DoubleNode(val);
            n.Next = Head;
            n.Prev = null;

            if (Head != null)
            {
                Head.Prev = n;
            }

            Head = n;
        }

        public void PrintList()
        {
            DoubleNode Prv = null;
            Console.Write("Doublly Linked List:");
            while (Head != null)
            {
                Prv = Head;
                Console.Write(Head.Val + " ");
                Head = Head.Next;
            }
            Console.WriteLine("\n");
            Console.Write("Doublly Linked List Reversed:");

            while (Prv != null)
            {
                Head = Prv;
                Console.Write(Head.Val + " ");
                Prv = Prv.Prev;
            }
        }
    }
}
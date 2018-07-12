﻿using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SwapPairs
    {

        public Node SwapNodes(Node head)
        {

            if (head == null)
                return null;

            Node Prev = null;
            Node current = head;
            Node runner = current.Next;

            while (current != null && runner != null)
            {

                current.Next = runner.Next;
                runner.Next = current;

                if (Prev == null)
                {
                    Prev = current;
                    head = runner;
                }
                else
                {
                    Prev.Next = runner;
                    Prev = Prev.Next.Next;

                }

                current = current.Next;
                if (current == null)
                    break;
                runner = runner.Next.Next.Next;
            }

            return head;
        }
    }
}

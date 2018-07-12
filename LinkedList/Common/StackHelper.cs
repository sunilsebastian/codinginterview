using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class StackHelper
    {

        public static LStack Create(int[] values)
        {
            var stk = new LStack();
            for (int i = 0; i < values.Length; i++)
            {
                stk.Push(values[i]);
            }

            return stk;
        }

        public static void PrintAll(LStack stk)
        {
            var node = stk.Head;
            while (node!=null)
            {
                Console.Write(node.Val +" ");
                node = node.Next;
            }

        }

        public static void PrintAll(Node n)
        {
            var node = n;
            while (node != null)
            {
                Console.Write(node.Val + " ");
                node = node.Next;
            }

        }


        public static void PopAll(LStack stk)
        {
            int num = stk.Pop();
            while (num > 0)
            {
                Console.Write(num + " ");
                num = stk.Pop();

            }
        }

    }
}

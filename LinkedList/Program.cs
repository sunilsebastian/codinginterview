using LinkedList.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            //create Stack
            var stk=  StackHelper.Create(new int[] { 10, 11, 12, 13, 14, 15 });
            StackHelper.PrintAll(stk);
            Console.WriteLine();
         
            //Create Queue
            var q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15,16 });
            QueueHelper.PrintAll(q);
            Console.WriteLine();

            //SwapNode
            SwapPairs sp = new SwapPairs();
            var swapedList= sp.SwapNodes(q.Head);
            QueueHelper.PrintAll(swapedList);
            Console.ReadLine();




        }

      
    }
}

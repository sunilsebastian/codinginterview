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
            Console.Write("Stack Values:");
            StackHelper.PrintAll(stk);
            Console.WriteLine();
         
            //Create Queue
            var q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15,16 });
            Console.Write("Queue Values:");
            QueueHelper.PrintAll(q);
            Console.WriteLine();

            //Reverse List
            var reversedQ= ReverseList.Reverse(q.Head);
            Console.Write("Reversed Queue Values:");
            QueueHelper.PrintAll(reversedQ);
            Console.WriteLine();

            //SwapNode
            q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            var swapedList= SwapPairs.SwapNodes(q.Head);
            Console.Write("Swaped Queue Values:");
            QueueHelper.PrintAll(swapedList);
            Console.WriteLine();


            //Sort Based on actual Value
            q = QueueHelper.Create(new int[] { 1,2,3,-4,-5,-6,-10 });
            var actualValueSorted = SortBasedOnAbsoluteValue.Sort1(q.Head);
            Console.Write("Sort Based on Actual values:");
            QueueHelper.PrintAll(actualValueSorted);
            Console.WriteLine();

            //Sort Based on actual Value
            q = QueueHelper.Create(new int[] { 1,2,3,4,5,6,7,8,9,10});
            int k = 3;
            var altRevList = AlternativeKNodes.ReverseAlterNativeKNodes(q.Head,k);
            Console.Write("Reversed Alternative K Nodes:");
            QueueHelper.PrintAll(altRevList);
            Console.WriteLine();

            //Reverse List
            q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            var reversedRecurQ = ReverseRecursively.Reverse(q.Head);
            Console.Write("Reverse Queue Values Recursively:");
            QueueHelper.PrintAll(reversedRecurQ);
            Console.ReadLine();

        }
     
    }
}

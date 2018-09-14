using LinkedList.Common;
using System;

namespace LinkedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create Stack
            var stk = StackHelper.Create(new int[] { 10, 11, 12, 13, 14, 15 });
            Console.Write("Create list(10, 11, 12, 13, 14, 15) as Stack :");
            StackHelper.PrintAll(stk);
            Console.WriteLine("\n");

            //Create Queue
            var q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            Console.Write("Create list(10, 11, 12, 13, 14, 15, 16 ) as Queue :");
            QueueHelper.PrintAll(q);
            Console.WriteLine("\n");

            //Check list is circular.
            bool isCircular = CheckListIsCircular.Check(q.Head);
            Console.Write("List(10, 11, 12, 13, 14, 15, 16 ) is Circular?:" + isCircular.ToString());
            Console.WriteLine("\n");

            //Reverse List
            var reversedQ = ReverseList.Reverse(q.Head);
            Console.Write("Reversed List( 10->11->12->13->14-> 15->16) Values:");
            QueueHelper.PrintAll(reversedQ);
            Console.WriteLine("\n");

            //SwapNode
            q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            var swapedList = SwapPairs.SwapNodes(q.Head);
            Console.Write("Swaped List( 10->11->12->13->14->15->16 ) Values in Pairs:");
            QueueHelper.PrintAll(swapedList);
            Console.WriteLine("\n");

            //Sort Based on actual Value
            q = QueueHelper.Create(new int[] { 1, 2, 3, -4, -5, -6, -10 });
            var actualValueSorted = SortBasedOnAbsoluteValue.Sort1(q.Head);
            Console.Write("Sort Based on Actual values in List(1-> 2->3->-4->-5-> -6-> -10):");
            QueueHelper.PrintAll(actualValueSorted);
            Console.WriteLine("\n");

            //Sort Based on actual Value
            q = QueueHelper.Create(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            int k = 3;
            var altRevList = AlternativeKNodes.ReverseAlterNativeKNodes(q.Head, k);
            Console.Write($"Reversed Alternative {k} Nodes in list(1->2->3->4->5->6->7->8->9->10 ):");
            QueueHelper.PrintAll(altRevList);
            Console.WriteLine("\n");

            //Reverse List
            q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            var reversedRecurQ = ReverseRecursively.Reverse(q.Head);
            Console.Write("Reverse List(10->11->12->13->14->15->16) Values Recursively:");
            QueueHelper.PrintAll(reversedRecurQ);
            Console.WriteLine("\n");

            //Merge Two Sorted Queues
            var q1 = QueueHelper.Create(new int[] { 1, 5 });
            var q2 = QueueHelper.Create(new int[] { 2, 3, 4 });
            var mergedList = MergeKSortedLists.MergeRecursive(q1.Head, q2.Head);
            Console.Write("Merge list1(1-> 5)  and list2( 2->3->4) :");
            QueueHelper.PrintAll(mergedList);
            Console.WriteLine("\n");

            //List Iterator
            var listIterator = new ListIterator();
            Console.Write("Write List in Order:");
            while (listIterator.HasAny())
            {
                Console.Write(listIterator.Next() + " ");
            }
            Console.WriteLine("\n");

            //deleting the middle node
            q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            var updatedList = DeleteNodeInTheMiddle.DeleteMiddleNode(q.Head);
            Console.Write("List(10-> 11->12->13->14->15->16) after deleting the middle node:");
            QueueHelper.PrintAll(updatedList);
            Console.WriteLine("\n");

            //NtheElement from the Last
            q = QueueHelper.Create(new int[] { 10, 11, 12, 13, 14, 15, 16 });
            int n = 5;
            var nthNode = NthElementFromLast.FindNthElementFromLast(q.Head, n);
            Console.Write(n + "th element from Last(10->11->12->13->14->15->16):" + nthNode.Val);
            Console.WriteLine("\n");

            //Double linkedlist
            var doubleList = new DoubleList();
            doubleList.InsertNode(10);
            doubleList.InsertNode(11);
            doubleList.InsertNode(12);
            doubleList.InsertNode(13);
            doubleList.InsertNode(14);
            doubleList.PrintList();
            Console.WriteLine("\n");

            //Circular linkedlist

            var circularList = new CircularList();

            circularList.SetLoopBackVal(20);

            circularList.Insert(10);
            circularList.Insert(20);
            circularList.Insert(30);
            circularList.Insert(40);
            circularList.Insert(50);
            circularList.SetLoopBack();

            //collition node
            Node collitionNode = circularList.GetCollitionNode();
            Console.Write("Colliding Node in a circular list(10->20->30->40->50->20):" + collitionNode.Val);
            Console.WriteLine("\n");

            //check a string is palindrum
            Palindrum palindrum = new Palindrum();
            bool result = palindrum.Check("MALAYALAM");
            Console.Write("Is 'MALAYALAM' a Palindrum word:" + result.ToString());
            Console.WriteLine("\n");

            //TBD
            //partition based on a pivot
            q = QueueHelper.Create(new int[] { 1, 3, 2, 9, 4, 7, 11, 5 });
            int pivot = 4;
            var partitionList = PartitionBasedOnPivot.Partition(q.Head, pivot);
            Console.Write($"Partition  List( 1->3->2->9->4->7->11->5 ) based on Pivot({pivot}) :");
            QueueHelper.PrintAll(partitionList);
            Console.WriteLine("\n");

            //Number addition
            LQueue num1 = QueueHelper.Create(new int[] { 8, 7 });
            LQueue num2 = QueueHelper.Create(new int[] { 8, 9 });
            var sum = NumberListAddition.AddNumList(num1.Head, num2.Head);
            Console.Write("List Addition List1(8->7) and List2(8->9):");
            QueueHelper.PrintAll(sum);
            Console.WriteLine("\n");

            var sum1 = NumberListAddition.AddNumListRecursion(num1.Head, num2.Head);
            Console.Write("List Addition List1(8->7) and List2(8->9) Recursively:");
            QueueHelper.PrintAll(sum);
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
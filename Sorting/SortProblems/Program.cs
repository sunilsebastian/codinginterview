using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
   
    public class Program
    {

        public static void Main(string[] args)
        {
            WellFormedBrackets.GetWellFormedBrackets(3);

            SumToTargetValue.check_if_sum_possible(new long[]{10,20}, 0);
            AllPossibleNQueen.GetNQueenPositions(4);

           var resultArray = GenerateAllExpression.Generate("222",24);
            PalindrumDecomposition.PalPartitions("aab");

            BSTCount.PrintBST(4);

            SubsetOfSet.GeneratSubset("ab");



            int[] list1 = new int[2] { 3, 3 };
            int[] list2 = new int[2] {5,-1};
            int[] list3 = new int[2] {-2, 4 };
            var closetPoints= KClosestPoints.KClosest(new int[][] {list1,list2,list3 },2);

            string[] output=LexicographicalOrder.Solve(new string[] { "key1 abcd", "key2 zzz", "key1 hello","key3 world", "key1 hello" });
            int[] res=KLargestElementsInStream.TopK(new int[] { 4, 8, 9, 6, 6, 2, 10, 2, 8, 1, 2 }, 9);


            MergeKSortedArrays mergeArrays = new MergeKSortedArrays();
            var mergeResult=mergeArrays.MergeArrays(new int[,] { { 1, 3, 5, 7 }, { 2, 4, 6, 8 }, { 0, 9, 10, 11 } });


            KthLargestNumberInStream kstream = new KthLargestNumberInStream(3, new int[] { 4, 5, 8, 2 });
            var val=kstream.Add(3);   // returns 4
            val=kstream.Add(5);      // returns 5
            val = kstream.Add(10);  // returns 5
            val = kstream.Add(9);   // returns 8
            val = kstream.Add(4);   // returns 8

            PriorityQueue<int> heap = new PriorityQueue<int>(false);
            heap.Enqueue(4, 4);
            heap.Enqueue(5, 5);
            heap.Enqueue(8, 8);
            heap.Enqueue(2, 2);
            Console.Write("PQ:");
            for (int i = 0; i < heap.Count(); i++)
                Console.Write($"{ heap.Dequeue()} ");

            Console.WriteLine();



            string s = "ab cd e j asd ljffg df";
            var result=SortBasedOnsize.Sort(s);
            Console.WriteLine();
            //Quick Sort
            int[] arr = new int[10]
            {
                1, 5, 4, 11, 20, 8, 2, 98, 90, 16
            };

            SelectionSort.Sort(new int[] { 1, 7, 2, 4, 5 });

            BubbleSort.Sort1(new int[] { 1, 7, 2, 4, 5 });

            QuickSort obj = new QuickSort();
            obj.Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("Quick Sorted Values:");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();

            int k = 5;
            var largest=KthLargestUnSortedArray.FindKthLargest(arr, 0, arr.Length - 1,arr.Length-k);
            Console.WriteLine($"{k}th largest element is: {largest}");


            var smallest = KthLargestUnSortedArray.FindKthLargest(arr, 0, arr.Length - 1,k-1);
            Console.WriteLine($"{k}th Smallest element is: {smallest}");

            Console.WriteLine();

            //Merge Sort
            arr = new int[7]
            {
                7,4,5,31,8,2,6
            };
            MergeSort.Sort(arr, 0, arr.Length - 1);
            Console.WriteLine("Merge Sorted Values:");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();

           //Heap Sort
           arr = new int[7]
            {
                7,4,5,31,8,2,6
             };
            HeapSort.Sort(arr);
            Console.WriteLine("Heap Sorted Values:");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();

            Console.ReadLine();
        }
    }
    
}

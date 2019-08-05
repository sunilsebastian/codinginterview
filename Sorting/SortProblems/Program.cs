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

            KthLargestNumberInStream kstream = new KthLargestNumberInStream(3, new int[] { 4, 5, 8, 2 });
            var val=kstream.Add(3);   // returns 4
            val=kstream.Add(5);      // returns 5
            val = kstream.Add(10);  // returns 5
            val = kstream.Add(9);   // returns 8
            val = kstream.Add(4);   // returns 8


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

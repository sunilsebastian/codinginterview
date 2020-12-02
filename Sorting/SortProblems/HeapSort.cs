﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class HeapSort
    {

        //Its first build max heap
        
        //in loop 
        // now  swap n-1 item and 0
        //now build again build max heap execet n-1

        public static  void Sort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // One by one extract an element from heap
            //n-1 because after swap the last element is already sorted.
            //we are pushing largest to last one by one
            for (int i = n - 1; i >0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is
        // an index in arr[]. n is size of heap
        private static void heapify(int[] arr, int n, int i)
        {
            int largest = i;  // Initialize largest as root
            int l = 2 * i + 1;  // left = 2*i + 1
            int r = 2 * i + 2;  // right = 2*i + 2

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                heapify(arr, n, largest);
            }
        }

        /* A utility function to print array of size n */
    }
}

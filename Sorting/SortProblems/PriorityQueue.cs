namespace SortProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PriorityQueue
    {
        private List<int> list;

        public PriorityQueue()
        {
            this.list = new List<int>();
        }

        public void Enqueue(int item)
        {
            list.Add(item);
            int n = list.Count;
            if (n < 2)
                return;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(n, i);
        }

        public int Dequeue()
        {
            int lastIndex = list.Count - 1;
            int temp = list[0];
            list[0] = list[lastIndex];
            list[lastIndex] = temp;

            list.Remove(temp);
            // call max heapify on the reduced heap
            heapify(list.Count, 0);
           
            return temp;
        }



        private  void heapify(int n, int i)
        {
            int largest = i;  // Initialize largest as root
            int l = 2 * i + 1;  // left = 2*i + 1
            int r = 2 * i + 2;  // right = 2*i + 2

            // If left child is larger than root
            if (l < n && list[l] > list[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && list[r] > list[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = list[i];
                list[i] = list[largest];
                list[largest] = swap;

                // Recursively heapify the affected sub-tree
                heapify(n, largest);
            }
        }

        public int Peek()
        {
           int frontItem = list[0];
            return frontItem;
        }

        public int Count()
        {
            return list.Count;
        }

      
    } 

} 

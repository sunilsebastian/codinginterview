using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    //        int k = 3;
    //        int[] arr = [4, 5, 8, 2];
    //        KthLargest kthLargest = new KthLargest(3, arr);
    //        kthLargest.add(3);   // returns 4
    //kthLargest.add(5);   // returns 5
    //kthLargest.add(10);  // returns 5
    //kthLargest.add(9);   // returns 8
    //kthLargest.add(4);   // returns 8
    public class KthLargestNumberInStream
    {
        //MinHeap
        public int K { get; set; }
        PQ<int> pq;
        int[] arr;

        public KthLargestNumberInStream(int k, int[] ar)
        {
            arr = ar;
            K = k;
            pq = new PQ<int>();
            for(int i=0;i<arr.Length;i++)
            {
                Add(arr[i]);
            }
                
        }
        public  int Add(int data)
        {
            if (pq.Count() == K)
            {
                if(data>pq.Peek())
                {
                    pq.Dequeue(); //Remove Min 
                    pq.Enqueue(data); //Add
                }
            }
            else
            {
                pq.Enqueue(data);
            }

            return pq.Peek();

        }

    }
}

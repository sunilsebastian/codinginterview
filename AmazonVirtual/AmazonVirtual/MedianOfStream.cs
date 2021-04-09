using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    public class MedianFinder
    {


            PQ<int> minH;
            PQ<int> maxH;

        /** initialize your data structure here. */
        public MedianFinder()
        {
            minH = new PQ<int>(true);
            /* By default Java provides min heap. For max heap, we need to pass in a appropriate comparator */
            maxH = new PQ<int>(true);
        }        
    

        public void addNum(int num)
        {
            //Max heap and minheap diffrerence would be equal or Max heap can have one more (odd)

            maxH.Enqueue(num);

            //Take top element of maxheap to minheap  balance the size
            //Max heap stores the Left sub arry and min heap stores the right sub array
            minH.Enqueue(maxH.Dequeue());

            if(minH.Count()>maxH.Count())
            {
                maxH.Enqueue(minH.Dequeue());
            }

        }

        public double findMedian()
        {
            if (minH.Count() == maxH.Count())
                return (double)(maxH.Peek() + minH.Peek()) * 0.5;
            else
                return (double)maxH.Peek();
        }
  
}
}

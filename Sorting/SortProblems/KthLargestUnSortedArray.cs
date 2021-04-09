using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class KthLargestUnSortedArray
    {
        public static int FindKthLargest(int[] arr,int start, int end,int k)
        {
                //partition is the exact position in a sorted array
                int p = Partition(arr, start, end);
              
                if (k<p)
                {
                   return FindKthLargest(arr, start, p - 1, k);
                }
                else if(k>p)
                {
                    return FindKthLargest(arr, p+1, end, k);

                }
                else
                {
                    return arr[p];
                }
                   
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int p = end;
            int i = start - 1;
            int temp;

            for(int j=start; j<end;j++)
            {
                if(arr[j]<=arr[p])
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[p];
            arr[p] = temp;
            return i + 1;
        }
    }
}

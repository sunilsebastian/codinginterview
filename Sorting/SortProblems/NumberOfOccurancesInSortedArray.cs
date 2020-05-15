using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public enum SortType
    {
        First,
        Second
    }
    public class NumberOfOccurancesInSortedArray
    {
       
        public static int GetNumberOfOccurancesInSortedArray(int[] arr,int target)
        {
            if (arr.Length == 0) return -1;

            var first=BinarySearch(arr, 0, arr.Length - 1, target, SortType.First);

            if (first == -1)
                return first;

            var second = BinarySearch(arr, first, arr.Length - 1, target, SortType.Second);

            return second-first +1;


        }

        public static int BinarySearch(int[] arr,int start, int end, int target,SortType type)
        {
            if (start > end) return -1;

            int mid = start + (end - start) / 2;

            if(arr[mid]==target)
            {
                if (type == SortType.First)
                {
                    if (mid == 0 || (arr[mid - 1] < target))
                        return mid;
                    else
                        return BinarySearch(arr, start, mid - 1, target, type);
                }
               else
                {
                    if (mid == end || (arr[mid + 1] > target))
                        return mid;
                    else
                       return BinarySearch(arr, mid + 1, end, target, type);

                }
            
            }
            else if(target<arr[mid])
            {
                return BinarySearch(arr, start, mid-1, target, type);
            }
            else 
            {
                return BinarySearch(arr, mid+1, end, target, type);
            }

        }
    }
}

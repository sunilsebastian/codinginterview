using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{
    //Binary Search
    //boundary binary search

    //First occurance of number in an array with duplicates
    //[1, 3, 3, 3, 3, 6, 10, 10, 10, 100]


    //Square root sqrt(8)
    //Find the first number whose sqr is less than or eaqual to 9 so its 3
    // 0 1 2 3 | 4 5 6 7 8 9   here taking right end of first partion . so return right

    //First element not smaller than Target 8  ans is 9
    //1 3 5 7 | 9 10 11 12  
    //[F F F F | T  T  T T]



    public class BinarySearch
    {
        public static int FindSqrRootOfnumber(int target)
        {
            int left = 0;
            int right = target;
            int sqrt = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid * mid <= target)
                {
                    sqrt = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return sqrt;

        }

        public static int FirstElemtentNotSmallerThanTarget(int[] arr, int left, int right, int target)
        {
            if (left > right)
                return arr[left];

            int mid = left + (right - left) / 2;

            if (arr[mid] >= target)
                return FirstElemtentNotSmallerThanTarget(arr, left, mid - 1, target);

            else
                return FirstElemtentNotSmallerThanTarget(arr, mid + 1, right, target);

        }

        //[0 1 2 3| 4 5 6 7 8 9] return right end of first partition 
        public static int FindSqrRootOfnumber(int left, int right, int target)
        {
            if (left > right)
                return right;

            int mid = left + (right - left) / 2;

            if (mid * mid > target)
                return FindSqrRootOfnumber(left, mid - 1, target);

            else
                return FindSqrRootOfnumber(mid + 1, right, target);

        }


        //find smallest element in sorted and rotated array
        //also we can say find smallest element less than <=last element
        //So ans is 10

        //[30,40,50,|10,20]

        public static int FindMinSortedRotated(int[] arr)
        {
            var result = FindMinSortedRotated(arr, 0, arr.Length - 1, arr[arr.Length - 1]);
            return result;
        }

        public static int FindMinSortedRotated(int[] arr, int left, int right, int target)
        {
            if (left > right)
                //because we need to return the left end of the partition
                return arr[left];

            int mid = left + (right - left) / 2;
            if (arr[mid] <= target)
            {
                return FindMinSortedRotated(arr, left, mid - 1, target);

            }
            else
            {
                return FindMinSortedRotated(arr, mid + 1, right, target);
            }

        }


        //Find min in sorted rotaed with duplicates . Here 3 appears both sides of 1
        // [3,1,3]
        public static int FindPivot(int[] nums, int start, int end)
        {
            if (start > end)
                return nums[start];

            int mid = start + (end - start) / 2;
            if (nums[mid] < nums[end])
                //here it is just mid not mid-1
                return FindPivot(nums, start, mid);
            else if (nums[mid] > nums[end])
                return FindPivot(nums, mid + 1, end);
            else
                //special case 
                return FindPivot(nums, start, end - 1);
        }


        public int peakIndexInMountainArray(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            //its equal to in recursion
          //  if(left>=right) return left;

            while (left < right)
            {
                int mi = left + (right - left) / 2;
                //this is the binary partion condition
                if (arr[mi] < arr[mi + 1])
                    left = mi + 1;
                else
                    right = mi;
            }
            return left;
        }
    }
}


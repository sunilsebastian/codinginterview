using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class MinSwapToSort
    {

      #region solution1
       

        public static int NumberOfSwapsToSort(int[] elems)
        {
            return Sort(elems, 0, elems.Length - 1);
        }
      
        private static int Sort(int[] input, int startIndex, int endIndex)
        {
            int mid;
            int count = 0;

            if (endIndex > startIndex)
            {
                
                mid = (endIndex + startIndex) / 2;
                count += Sort(input, startIndex, mid);
                count += Sort(input, (mid + 1), endIndex);
                count += Merge(input, startIndex, mid, endIndex);
            }

            return count;
        }

        private static int Merge(int[] input, int left, int mid, int right)
        {
            int rightIndex = mid+1;
            int leftIndex= left;
            int resultIndex = 0;

            int[] temp = new int[right - left + 1];

            int count = 0;

            while ((leftIndex <= mid) && (rightIndex <= right))
            {
                //mid is the first element of the second compartment
                if (input[leftIndex] <= input[rightIndex])
                {
                    temp[resultIndex++] = input[leftIndex++];
                }
                else
                {
                    temp[resultIndex++] = input[rightIndex++];

                    //here mid+1 is rightStart
                    count += (mid+1) - leftIndex;
                  
                    //as both compartments are sorted
                    //all the elements  in left partion is greater than mid
                    //so there will rightStart-leftIndex  swaps needed
                }
            }
            while (leftIndex <= mid)
            {
                temp[resultIndex++] = input[leftIndex++];
            }
            while (rightIndex <= right)
            {
                temp[resultIndex++] = input[rightIndex++];
            }

            //placing temp array to input
            int index = 0;
            for(int i=left;i<=right;i++)
            {
                input[i] = temp[index++];
            }
            return count;
        }

        #endregion


      #region solution2

        private static int[] res;

        class Pair
        {
            public int val;
            public int idx;

            public Pair(int val, int idx)
            {
                this.val = val;
                this.idx = idx;
            }
        }

        public static  int  GetSwapCount(int[] nums)
        {
            res = new int[nums.Length];
            Pair[] pair = new Pair[nums.Length];

            for (int i = 0; i < pair.Length; i++)
            {
                pair[i] = new Pair(nums[i], i);
            }

            MergeSort(pair, 0, nums.Length - 1);
            return res.Sum();
        }
        private static void MergeSort(Pair[] nums, int left, int right)
        {
            if (left >= right)
                return;
            int mid = left + (right - left) / 2;

            MergeSort(nums, left, mid);
            MergeSort(nums, mid + 1, right);

            int count = 0;

            int leftStart = left;
            int rightStart = mid + 1;


            while (leftStart <= mid)
            {
                if (rightStart <= right && nums[leftStart].val > nums[rightStart].val)
                {
                    count++;
                    rightStart++;
                }
                else
                {
                    res[nums[leftStart].idx] += count;
                    leftStart++;
                }
            }

            // merge

            int rightIndex = mid + 1;
            int leftIndex = left;
            int resultIndex = 0;
            Pair[] temp = new Pair[right - left + 1];
            while ((leftIndex <= mid) && (rightIndex <= right))
            {
                //mid is the first element of the second compartment
                if (nums[leftIndex].val <= nums[rightIndex].val)
                {
                    temp[resultIndex++] = nums[leftIndex++];
                }
                else
                {
                    temp[resultIndex++] = nums[rightIndex++];

                }
            }
            while (leftIndex <= mid)
            {
                temp[resultIndex++] = nums[leftIndex++];
            }
            while (rightIndex <= right)
            {
                temp[resultIndex++] = nums[rightIndex++];
            }

            //placing temp array to input
            int index = 0;
            for (int i = left; i <= right; i++)
            {
                nums[i] = temp[index++];
            }

        }
        #endregion
    }


}

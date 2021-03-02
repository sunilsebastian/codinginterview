using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given an array nums, we call(i, j) an important reverse pair if i<j and nums[i]> 2* nums[j].

//You need to return the number of important reverse pairs in the given array.

//Example1:

//Input: [1,3,2,3,1]
//Output: 2
//Example2:

//Input: [2,4,3,5,1]
//Output: 3
namespace SortProblems
{

    //Divide and Conquor
    public class ReversePairs
    {
        public int GetReversePairs(int[] nums)
        {
            return Sort(nums, 0, nums.Length - 1);
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

                int j = mid + 1;
                int i = startIndex;
                int currentCount = 0;
                while (i <= mid)
                {
                    if (j <= endIndex && input[i] > input[j] * 2L)
                    {
                        currentCount++;
                        j++;
                    }
                    else { 
                        count += currentCount;
                        i++;
                    }
                }
                Merge(input, startIndex, mid, endIndex);
            }

            return count;
        }

        private static void Merge(int[] input, int left, int mid, int right)
        {
            int rightIndex = mid + 1;
            int leftIndex = left;
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
            for (int i = left; i <= right; i++)
            {
                input[i] = temp[index++];
            }

        }
    }
}

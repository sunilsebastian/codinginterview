using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class MergeSort
    {
        public static void Sort(int[] input, int startIndex, int endIndex)
        {
            int mid;

            if (startIndex >= endIndex)
                return;

                mid = (endIndex + startIndex) / 2;
                Sort(input, startIndex, mid);
                Sort(input, (mid + 1), endIndex);
                Merge(input, startIndex, mid, endIndex);
        }

        private static void Merge(int[] input, int left, int mid, int right)
        {
            int rightIndex = mid + 1;
            int leftIndex = left;
            int resultIndex = 0;

            int[] temp = new int[right - left + 1];

            while ((leftIndex <= mid) && (rightIndex <= right))
            {
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


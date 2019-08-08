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

            //if (endIndex > startIndex)
            //{
                mid = (endIndex + startIndex) / 2;
                Sort(input, startIndex, mid);
                Sort(input, (mid + 1), endIndex);
                Merge(input, startIndex, (mid + 1), endIndex);
            //}
        }

        private static void Merge(int[] input, int left, int mid, int right)
        {
         
            var leftEnd = mid - 1;
            var resultIndex = left;
            var resultSize = right - left + 1;
            int[] temp = new int[input.Length];

            while ((left <= leftEnd) && (mid <= right))
            {
                //mid is the first element of the second compartment
                if (input[left] <= input[mid])
                {
                    temp[resultIndex++] = input[left++];
                }
                else
                {
                    temp[resultIndex++] = input[mid++];
                }
            }
            //placing remaining element in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[resultIndex++] = input[left++];
            }

            //placing remaining element in temp from right sorted array
            while (mid <= right)
            {
                temp[resultIndex++] = input[mid++];
            }

            //placing temp array to input
            for (int i = 0; i < resultSize; i++)
            {
                input[right] = temp[right];
                right--;
            }
        }
    }
}

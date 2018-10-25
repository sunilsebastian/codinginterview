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

            if (endIndex > startIndex)
            {
                mid = (endIndex + startIndex) / 2;
                Sort(input, startIndex, mid);
                Sort(input, (mid + 1), endIndex);
                Merge(input, startIndex, (mid + 1), endIndex);
            }
        }

        private static void Merge(int[] input, int left, int mid, int right)
        {
            //Merge procedure takes theta(n) time
            int[] temp = new int[input.Length];
            int i, leftEnd, lengthOfInput, tmpPos;
            leftEnd = mid - 1;
            tmpPos = left;
            lengthOfInput = right - left + 1;
            //Console.WriteLine(string.Format("{0} {1}",input.Length,lengthOfInput));

            //selecting smaller element from left sorted array or right sorted array and placing them in temp array.
            while ((left <= leftEnd) && (mid <= right))
            {
                if (input[left] <= input[mid])
                {
                    temp[tmpPos++] = input[left++];
                }
                else
                {
                    temp[tmpPos++] = input[mid++];
                }
            }
            //placing remaining element in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[tmpPos++] = input[left++];
            }

            //placing remaining element in temp from right sorted array
            while (mid <= right)
            {
                temp[tmpPos++] = input[mid++];
            }

            //placing temp array to input
            for (i = 0; i < lengthOfInput; i++)
            {
                input[right] = temp[right];
                right--;
            }
        }
    }
}

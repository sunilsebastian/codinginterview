using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class MinSwapToSort
    {
        //0  1 2 3
        // 5 4 1 2

        //after sort
        //0 1 2  3
        //1  2 4 5

        //loop through sorted
        //if not maching loop dict to find index of actual
        //swap
        private static int minSwaps(int[] elems)
        {
            int counter = 0;
            var map = BuildMap(elems);
            var copy = map.Keys.ToArray();

            Array.Sort(elems);

            for (int i = 0; i < map.Keys.Count; i++)
            {
                if (copy[i] != elems[i])
                {
                    //Swap(copy, i, );
                    int j = map[elems[i]];
                    int temp = copy[j];
                    copy[j] = copy[i];
                    copy[i] = temp;
                    counter++;
                }
            }

            return counter;
        }

        private static Dictionary<int, int> BuildMap(int[] elems)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < elems.Length; i++)
            {
                map[elems[i]] = i;
            }
            return map;
        }

        //private static void Swap(int[] elems, int i, int j)
        //{
        //	int temp = elems[j];
        //	elems[j] = elems[i];
        //	elems[i] = temp;
        //}
        public static int NumberOfSwapsToSort(int[] elems)
        {
            return Sort(elems, 0, elems.Length - 1);
        }
            //-------------------------------------------------------
        private static int Sort(int[] input, int startIndex, int endIndex)
        {
            int mid;

            int count = 0;

            if (endIndex > startIndex)
            {
                //if (endIndex > startIndex)
                //{
                mid = (endIndex + startIndex) / 2;
                count += Sort(input, startIndex, mid);
                count += Sort(input, (mid + 1), endIndex);
                count += Merge(input, startIndex, (mid + 1), endIndex);
            }

            return count;
            //}
        }

        private static int Merge(int[] input, int left, int mid, int right)
        {

            var leftEnd = mid - 1;
            var rightStart = mid;
            var resultIndex = left;
            var resultSize = right - left + 1;
            int[] temp = new int[input.Length];
            int count = 0;

            while ((left <= leftEnd) && (rightStart <= right))
            {
                //mid is the first element of the second compartment
                if (input[left] <= input[mid])
                {
                    temp[resultIndex++] = input[left++];
                }
                else
                {
                   
                    temp[resultIndex++] = input[rightStart++];

                    //here mid is rightStart
                    count += (mid - left);
                    //as both compartments are sorted
                    //all the elements  in left partion is greater than mid
                    //so there will mid-left  swaps needed

                }
            }
            //placing remaining element in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[resultIndex++] = input[left++];
            }

            //placing remaining element in temp from right sorted array
            while (rightStart <= right)
            {
                temp[resultIndex++] = input[rightStart++];
            }

            //placing temp array to input
            for (int i = 0; i < resultSize; i++)
            {
                input[right] = temp[right];
                right--;
            }
            return count;
        }
    }

   
}

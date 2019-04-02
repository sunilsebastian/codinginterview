 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class CircularArrayLargestSum
    {
        public static int MaxSubarraySumCircular(int[] arr)
        {

            int n = arr.Length;
            int max_kadane = kadane(arr);

            int max_wrap = 0;
            for (int i = 0; i < n; i++)
            {
                max_wrap += arr[i];
                arr[i] = -arr[i];
            }


            max_wrap = max_wrap + kadane(arr);
            if (max_wrap == 0) return max_kadane;

            return (max_wrap > max_kadane) ? max_wrap : max_kadane;

        }

        private static  int kadane(int[] arr)
        {
            int max = arr[0];
            int currMax = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                currMax = Math.Max(arr[i], arr[i] + currMax);
                max = Math.Max(max, currMax);
            }
            return max;
        }
    }
}

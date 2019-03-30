using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SlidingWindowMaximum
    {
        public static void PrintSlidingWindowMaximum1(int[] arr, int k)
        {
            int j, max;

            for (int i = 0; i <= arr.Length - k; i++)
            {

                max = arr[i];

                for (j = 1; j < k; j++)
                {
                    if (arr[i + j] > max)
                        max = arr[i + j];
                }
                Console.Write(max + " ");
            }
        }

        public static int[] PrintSlidingWindowMaximum(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0) return new int[0];
            int start = 0;
            int count = 0;
            int len = 0;
            if (arr.Length - k < 0)
                len = 1;
            else
                len = (arr.Length - k) + 1;
            int[] maxArr = new int[len];

            while ((start + k) <= arr.Length)
            {
                int maxx = Int32.MinValue;
                for (int i = start; i < (start + k); i++)
                {
                    maxx = Math.Max(maxx, arr[i]);
                }
                maxArr[count++] = maxx;
                start++;
            }
            return maxArr;
        }
    }
}

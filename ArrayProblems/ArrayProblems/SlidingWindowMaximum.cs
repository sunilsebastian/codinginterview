using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SlidingWindowMaximum
    {
        public static void PrintSlidingWindowMaximum(int[] arr, int k)
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
    }
}

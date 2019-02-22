using System;

namespace ArrayProblems
{
    public class DutchNationalFlag
    {
        // Sort the input array, the array is assumed to
        // have values in {0, 1, 2}
        public static void Sort(int[] arr)
        {
            int lo = 0;
            int hi = arr.Length - 1;
            int mid = 0, temp = 0;

            while (mid <= hi)
            {
                switch (arr[mid])
                {
                    case 0:
                        {
                            temp = arr[lo];
                            arr[lo] = arr[mid];
                            arr[mid] = temp;
                            lo++;
                            mid++;
                            break;
                        }
                    case 1:
                        mid++;
                        break;

                    case 2:
                        {
                            temp = arr[mid];
                            arr[mid] = arr[hi];
                            arr[hi] = temp;
                            hi--;
                            break;
                        }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
   
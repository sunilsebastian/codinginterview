using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Sumupto3numbers
    {
        public static void PrintNumbers(int[] arr, int sum)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < arr.Length - 2; i++)
            {
                int cur_sum = sum - arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (hs.Contains(cur_sum - arr[j]))
                    {
                        Console.Write($"{arr[i]},{arr[j]},{cur_sum - arr[j]}");
                        return;
                    }
                    hs.Add(arr[j]);
                }
            }
        }


        public static string[] ThreeSum(int[] arr)
        {
            var result = new List<string>();
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if ((i > 0 && arr[i] == arr[i - 1]))
                {
                    continue;
                }
                else
                {
                    int start = i + 1;
                    int end = arr.Length - 1;
                    int curr_sum = -arr[i];

                    while (start < end)
                    {
                        if (arr[start] + arr[end] == curr_sum)
                        {
                            result.Add($"{arr[i]},{arr[start]},{arr[end]}");

                            while (start < end && arr[start] == arr[start + 1])
                            {
                                start++;
                            }
                            while (start < end && arr[end] == arr[end - 1])
                            {

                                end--;
                            }
                            start++;
                            end--;
                        }
                        else if (arr[start] + arr[end] < curr_sum)
                        {
                            start++;
                        }
                        else
                        {
                            end--;
                        }
                    }
                }
            }

            return result.ToArray();
        }

        public bool PrintNumbersSorted(int[] A, int sum)
        {
            int l, r;

            int arr_size = A.Length;

            /* Sort the elements */
            Array.Sort(A);

            for (int i = 0; i < arr_size - 2; i++)
            {
                l = i + 1; 
                r = arr_size - 1; // index of the last element 
                while (l < r)
                {
                    if (A[i] + A[l] + A[r] == sum)
                    {
                        Console.Write("Triplet is " + A[i] +
                                        ", " + A[l] + ", " + A[r]);
                        return true;
                    }
                    else if (A[i] + A[l] + A[r] < sum)
                        l++;

                    else // A[i] + A[l] + A[r] > sum 
                        r--;
                }
            }
            return false;
        }
    }
}

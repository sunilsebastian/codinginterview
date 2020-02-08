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

        //static List<IList<int>> lst1 = new List<IList<int>>();
        //static Dictionary<int, int> dict = new Dictionary<int, int>();
        //public static IList<IList<int>> ThreeSum1(int[] nums)
        //{
        //    for (int j = 0; j < nums.Length - 2; j++)
        //    {
        //        TwoSum1(nums, j + 1, nums[j]);

        //    }
        //    return lst1;
        //}

        //private static void TwoSum1(int[] nums, int sourceIndex, int val)
        //{
        //    int target = 0;
        //    for (int i = sourceIndex; i < nums.Length; i++)
        //    {
        //        int sum = val + nums[i];
        //        if (dict.ContainsKey(target - sum))
        //        {
        //            var lst = new List<int> { val, nums[i], target - sum };
        //            lst1.Add(lst);

        //        }
        //        else
        //        {
        //            if (!dict.ContainsKey(nums[i]))
        //            {
        //                dict.Add(nums[i], i);
        //            }
        //        }
        //    }
        //}


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

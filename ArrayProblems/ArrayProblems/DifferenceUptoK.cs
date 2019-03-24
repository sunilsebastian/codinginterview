using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class DifferenceUptoK
    {
        public static int  PrintPaiirsDifferenceUpToK(int[] arr,int k)
        {
            if (k < 0 || arr == null || arr.Length == 0)
                return 0;

            int count = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            foreach (var key in dict.Keys)
            {
                if (k == 0)
                {
                    //if >=2  menas there is one pair with difference of zero.
                    if (dict[key] >= 2)
                    {
                        count++;

                    }
                }
                else
                {
                    int sum = key + k;
                    if (dict.ContainsKey(sum))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static void PrintPaiirsDifferenceUpToKSorted(int[] arr, int k)
        {
            Array.Sort(arr);
            int l = 0;
            int r = 1;
            while (r < arr.Length)
            {
                if (arr[r] - arr[l] == k)
                {

                    Console.Write($"({arr[r]},{arr[l] })");
                    l++;
                    r++;
                }
                else if (arr[r] - arr[l] > k)
                {
                    l++;
                }
                else // arr[r] - arr[l] < sum 
                    r++;
            }
         
        }
    }
}

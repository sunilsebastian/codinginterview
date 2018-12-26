using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class DifferenceUptoK
    {
        public static void  PrintPaiirsDifferenceUpToK(int[] arr,int k)
        {
            HashSet<int> hs = new HashSet<int>();
            for(int i=0;i< arr.Length;i++)
            {
                hs.Add(arr[i]);
            }

            for(int i=0;i<arr.Length;i++)
            {
                int sum = arr[i]+k;
                int diff = arr[i] - k;
                if(hs.Contains(sum) )
                {
                    Console.Write($"({arr[i]},{sum})");
                }

                if (hs.Contains(diff))
                {
                    Console.Write($"({arr[i]},{diff})");
                }
                hs.Remove(arr[i]);
            }
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

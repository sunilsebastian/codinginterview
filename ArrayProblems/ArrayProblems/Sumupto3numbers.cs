using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public  class Sumupto3numbers
    {
        public static void PrintNumbers(int[] arr, int sum)
        {
            HashSet<int> hs = new HashSet<int>();
            for(int i=0;i<arr.Length-2;i++)
            {
                int cur_sum = sum - arr[i];
                for(int j=i+1;j<arr.Length;j++)
                {
                   if(hs.Contains(cur_sum-arr[j]))
                    {
                        Console.Write($"{arr[i]},{arr[j]},{cur_sum - arr[j]}");
                        return;
                    }
                    hs.Add(arr[j]);
                }
            }
        }
    }
}

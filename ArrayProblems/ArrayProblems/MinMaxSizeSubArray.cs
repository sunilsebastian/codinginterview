using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MinMaxSizeSubArray
    {
       public static int  FindMaximumSizeSubarraySumEqualsk(int[] arr, int k)
        {
            //lookup in dict for sum and sum-k

            int maxSize = 0;
            int sum = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);

            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
                if(!dict.ContainsKey(sum))
                    dict.Add(sum, i);

                if(dict.ContainsKey(sum-k))
                {
                    maxSize = Math.Max(maxSize, i - dict[sum - k]);
                }
            }
            return maxSize;
        }

        public static int FindMinumSizeSubarraySumEqualsk(int[] arr, int k)
        {
            int minSize = Int32.MaxValue;
            int sum = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, -1);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (!dict.ContainsKey(sum))
                    dict.Add(sum, i);

                if (dict.ContainsKey(sum - k))
                {
                    minSize = Math.Min(minSize, i - dict[sum - k]);
                }
            }
            return minSize;
        }
    }
}

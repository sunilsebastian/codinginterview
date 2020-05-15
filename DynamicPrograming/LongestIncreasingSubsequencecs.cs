using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class LongestIncreasingSubsequencecs
    {
        public int GetLengthOfLongestIncreasingSubSequence(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int[] max = new int[nums.Length];
            int result = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                // set entire max array with values as 1 initially 
                max[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        max[i] = Math.Max(max[i], max[j] + 1);
                    }
                }
                result = Math.Max(max[i], result);
            }

            //int result = 0;
            //for (int i = 0; i < max.Length; i++)
            //{
            //    if (max[i] > result)
            //        result = max[i];
            //}
            return result;
        }

        public static  int LongestIncreasingSubsequenceRecursive(int[] arr)
        {
            int maxLen = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int len = LongestSubsequenceRecursive(arr, i + 1, arr[i]);
                if (len > maxLen)
                {
                    maxLen = len;
                }
            }
            return maxLen + 1;
        }

        private static int LongestSubsequenceRecursive(int[] arr, int pos, int lastNum)
        {
            if (pos == arr.Length)
            {
                return 0;
            }
            int t1 = 0;
            if (arr[pos] > lastNum)
            {
                t1 = 1 + LongestSubsequenceRecursive(arr, pos + 1, arr[pos]);
            }
            int t2 = LongestSubsequenceRecursive(arr, pos + 1, lastNum);
            return Math.Max(t1, t2);
        }


    }
}
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

        //https://leetcode.com/explore/challenge/card/june-leetcoding-challenge/540/week-2-june-8th-june-14th/3359/
        public IList<int> LargestDivisibleSubset(int[] nums)
        {

            if (nums.Length == 1) return new List<int> { nums[0] };
            List<int> result = new List<int>();
            int[] dp = new int[nums.Length];

            int max = 1;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[i] || (nums[i] % nums[j]) != 0) continue;

                    dp[i] = Math.Max(dp[i], dp[j] + 1);

                    max = Math.Max(max, dp[i]);
                }

            }
            //idx 0 1 2 3
            //arr 1 2 3 6
            //dp  1 2 2 3
            int prev = -1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (dp[i] == max)
                {
                    if (prev == -1 || prev % nums[i] == 0)
                    {
                        result.Add(nums[i]);
                        max = max - 1; //going back
                        prev = nums[i];
                    }
                }
            }
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
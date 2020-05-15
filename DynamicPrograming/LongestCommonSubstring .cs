using System;

namespace DynamicPrograming
{
    public class LongestCommonSubstring
    {
        public static int GetLongestCommonSubstring(string str1, string str2)
        {
            int[,] dp = new int[str1.Length + 1, str2.Length + 1];

            int max = 0;
            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        if (max < dp[i, j])
                        {
                            max = dp[i, j];
                        }
                    }
                }
            }
            return max;
        }

        public static int max = Int32.MinValue;
        public static int GetLongestCommonSubstringRecur(string str1, string str2)
        {
            GetLongestCommonSubstringRecurHelper(str1, str2, str1.Length-1, str2.Length - 1);
            return max;
        }

        public static int GetLongestCommonSubstringRecurHelper(string str1, string str2, int m, int n)
        {
            if (m == -1|| n == -1)
                return 0;

            if (str1[m] == str2[n])
            {
                var res = 1 + GetLongestCommonSubstringRecurHelper(str1, str2, m -1, n- 1);
                max = Math.Max(res, max);
                return res;
            }
            else
            {
                var res =Math.Max(GetLongestCommonSubstringRecurHelper(str1, str2, m, n - 1), GetLongestCommonSubstringRecurHelper(str1, str2, m-1, n));
                max = Math.Max(res, max);
                return 0;
            }
        }
    }
    }

   
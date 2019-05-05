using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class LongestCommonSubsequence
    {
        public static int GetLongestCommonSubsequence(String s1, String s2)
        {
            int m =s1.Length;
            int n = s2.Length;
            int[,] dp = new int[m + 1,n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    //set first row and column to all zeros
                    if (i == 0 || j == 0)
                    {
                        dp[i,j] = 0;
                    }
                    //check the char is equal
                    else if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i,j] = 1 + dp[i - 1,j - 1];
                    }
                    //when the characters are different
                    else
                    {
                        dp[i,j] = Math.Max(dp[i - 1,j], dp[i,j - 1]);
                    }
                }
            }

            return dp[m,n];
        }
    }
}

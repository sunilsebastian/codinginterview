using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public  class DifficultyOfJobSchedule
    {
        public static int MinDifficulty(int[] job, int d)
        {
            int n = job.Length;
            if (n < d) return -1;
            int[,] dp = new int[d + 1,n + 1];
            for (int i = 1; i <= n; i++) 
                dp[1,i] = Math.Max(dp[1,i - 1], job[i - 1]);

            for (int i = 2; i <= d; i++)
            {
                //this loop is for identifying number of 
                for (int j = i; j <= n; j++)
                {
                    //take one
                    dp[i, j] = Int32.MaxValue;
                    int max = job[j - 1];

                    for (int k = j; k >= i; k--)
                    {
                        max = Math.Max(job[k-1], max);
                        dp[i, j] = Math.Min(dp[i, j], dp[i - 1, k-1] + max);
                    }
                 
                }
            }
            return dp[d, n];
        }
    }
}

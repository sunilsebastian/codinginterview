using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    //Refer book
    public class PerfectSquare
    {
        public static int NumSquares(int n)
        {
            int[] dp = new int[n + 1];

            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                dp[i] = i;
                for (int j = 1; j * j <= i; j++)
                    dp[i] = Math.Min(dp[i], dp[i - (j * j)] + 1);
            }
            return dp[n];
        }
    }
}

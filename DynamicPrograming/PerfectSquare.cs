using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class PerfectSquare
    {
        public static int GetPenumSquares(int n)
        {
            int max = (int)Math.Sqrt(n);

            int[] dp = new int[n + 1];
            dp=dp.Select(i => Int32.MaxValue).ToArray();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= max; j++)
                {
                    if (i == j * j)
                    {
                        dp[i] = 1;
                    }
                    else if (i > j * j)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                    }
                }
            }

            return dp[n];
        }
    }
}

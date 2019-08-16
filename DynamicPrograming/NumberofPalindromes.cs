using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class NumberofPalindromes
    {
        public static long GetCount(int n)
        {
            long[] dp=new long[n + 1];
            int m = 26;
            dp[0] = 1;
            dp[1] = dp[2] = m;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = m * dp[i - 2];
            }
            return dp[n];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            int[] dp = new int[s.Length + 1];
            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1;
            for (int i = 2; i <= s.Length; i++)
            {
                int oneDigit = Int32.Parse(s.Substring(i - 1, 1));
                int twoDigit = Int32.Parse(s.Substring(i - 2, 2));
                if (oneDigit >= 1)
                {
                    dp[i] += dp[i - 1];

                }
                if (twoDigit >= 10 && twoDigit <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }
            return dp[s.Length];
        }
    }
}

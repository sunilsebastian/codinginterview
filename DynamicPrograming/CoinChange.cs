using System;
using System.Linq;

namespace DynamicPrograming
{
    public class CoinChange
    {
        public static int GetMinimumCoinChangeForTargetAmt(int[] coins, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            int[] dp = new int[amount + 1];
            dp = dp.Select(i => Int32.MaxValue).ToArray();
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (i == coin)
                    {
                        dp[i] = 1;
                    }
                    else if (i > coin)
                    {
                        if (dp[i - coin] == Int32.MaxValue)
                        {
                            continue;
                        }
                        dp[i] = Math.Min(dp[i - coin] + 1, dp[i]);
                    }
                }
            }

            if (dp[amount] == Int32.MaxValue)
            {
                return -1;
            }

            return dp[amount];
        }
    }
}
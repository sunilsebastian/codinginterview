using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{

   //  https://leetcode.com/articles/coin-change-ii/
    public class CoinChange2
    {
        public int Change(int amount, int[] coins)
        {

            int[] dp = new int[amount + 1];

            //only one way we can do for amount 0
            dp[0] = 1;

            foreach (var coin in coins)
            {
                //start from coin because e.g amounts less than coin:2 are not impacted by the presence of 2 cent coins
                for (int amt = coin; amt < dp.Length; amt++)
                {
                    //dp[amt] is without considering coin (exclude) or current value 
                    //dp[amt - coin] include coin
                    dp[amt] = dp[amt] + dp[amt - coin];
                }
            }
            return dp[amount];
        }
    }
}

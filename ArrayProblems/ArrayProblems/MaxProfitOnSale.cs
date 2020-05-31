using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MaxProfitOnSale
    {
        public static int BestPrice(int[] arr)
        {
            int maxProfit = 0;
            int currentMin = arr[0];
            for(int i = 1;i<arr.Length;i++)
            {
                maxProfit = Math.Max(maxProfit, arr[i] - currentMin);

                currentMin = Math.Min(currentMin, arr[i]);
            }
            return maxProfit;
        }

        /* https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
        // sum of all posititive diffs while traversing array
        Input: [7,1,5,3,6,4]
        Output: 7
        Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
             Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.

        */
        public int MaxProfit_II(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int diff = prices[i] - prices[i - 1];
                if (diff > 0)
                {
                    profit += diff;
                }
            }
            return profit;
        }
    }

   
}

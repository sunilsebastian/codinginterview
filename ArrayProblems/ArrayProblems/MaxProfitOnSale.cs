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
    }
}

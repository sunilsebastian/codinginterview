using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

    //[ 5 3  2 4 1 2]  Ans:[4 5] passed
    //[1 2 5 8 4] Ans:[5 8]  passed
    //[8, 2, 2, 2, 9 ] Ans:[8,9] passed
    public class OptimizeBoxweight
    {
        public static List<int> optimizingBoxWeights(int[] weights)
        {
            List<(int, int)> arr = new List<(int, int)>();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int sum = weights.Sum();

            for (int i = 0; i < weights.Length; i++)
            {
                if (!dict.ContainsKey(weights[i]))
                {
                    dict.Add(weights[i], 1);
                }
                else
                    dict[weights[i]]++;
            }

            foreach (var item in dict)
            {
                if (item.Value > 1)
                    arr.Add((item.Key * item.Value, item.Value));
                else
                    arr.Add((item.Key, item.Value));

            }
            int maxW = (weights.Length % 2 == 0) ? (weights.Length / 2) - 1 : (weights.Length / 2);
            return Knapsack(maxW, arr.Count, arr);
        }

        public static List<int> Knapsack(int maxW, int arrSize, List<(int, int)> arr)
        {
            List<int> result = new List<int>();

            int[,] dp = new int[arrSize + 1, maxW + 1];
            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLength(1); j++)
                {
                    int value = arr[i - 1].Item1;
                    int wt = arr[i - 1].Item2;
                    if (wt > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], value + dp[i - 1, j - wt]);
                    }
                }
            }

            int res = dp[arrSize, maxW];
            for (int i = arrSize; i > 0 && res > 0; i--)
            {
                //exclude scenario so should not be added
                if (res == dp[i - 1, maxW])
                    continue;
               
                //include scenario so added to the list
                else
                {
                    if (arr[i - 1].Item2 > 1)
                        result.AddRange(Enumerable.Repeat(arr[i - 1].Item1, arr[i - 1].Item2));
                    else
                        result.Add(arr[i - 1].Item1);

                    res = res - arr[i - 1].Item1;
                    maxW = maxW - arr[i - 1].Item2;
                }
            }
            return result;
        }
    }
}


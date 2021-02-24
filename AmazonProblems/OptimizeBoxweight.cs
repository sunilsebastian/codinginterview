using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{

    //[3,7,5,6,2]

    //[3,1,2,4,5]

    //[0,1,5,6]

    //[4,3,5,9,11]

    //[0,0,2,2,3]

    //[3,1,1,2,2,1]

    //[6,2,6,5,1,2]

    //[1,2,3,100]

    //[1,5,10,20,5,6,7]

    //[16,14,13,13,12,10,9,3]

    //[4,14,15,16,17]

    //[10,10]

    //[5,8,13,27,14]

    //[5,5,6,5]

    //[12,30,30,32,42,49]

    //[1,1,1,3]

    //[2,5,5,9]

    //[2,2,4,5,5,11]

    //[5,5,5,10,10,10,11] --test it
    public class OptimizeBoxweight
    {

        #region greedy
        public static List<int> GetBoxWeight(List<int> weights)
        {
            int n = weights.Count();
            weights.Sort();
            Dictionary<int,int> dict = new Dictionary<int, int>();
            int sum = 0;
            foreach (var weight in weights)
            {
                sum += weight;

                if (!dict.ContainsKey(weight))
                    dict.Add(weight, 1);
                else
                    dict[weight]++;
            }


            List<int> result = new List<int>();
           
            int sumSetA = 0;
            int countSetA = 0;
            HashSet<int> visited = new HashSet<int>();
            int limit = n % 2 == 0 ? n / 2 - 1 : n / 2;

            for (int i = n - 1; i >= 0; i--)
            {

                if (visited.Contains(weights[i])) continue;
               
                //repeat count of current weight
                int count = dict[weights[i]];
               
                //mark current value as visited
                visited.Add(weights[i]);

                if (countSetA + count <= limit)
                {
                    sum -= (count * weights[i]);
                     sumSetA += count * weights[i];
                    for (int j = 0; j < count; j++)
                    {
                        result.Add(weights[i]);
                    }
                    countSetA += count;
                }
            }
            result.Sort();

            if (sumSetA > sum) return result;
            return null;

            //if (sumSetA <= (sum- sumSetA)) return null;
            //return result;
        }
        #endregion


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
            int maxItemCount = (weights.Length % 2 == 0) ? (weights.Length / 2) - 1 : (weights.Length / 2);
            return Knapsack(maxItemCount, arr.Count, arr, sum);
        }

        public static List<int> Knapsack(int maxItemCount, int arrSize, List<(int, int)> arr,int sum)
        {
            //maxItemCount is the maximum size of the targeted subarray 
            // arrSize is the number of non repeating elements;
            List<int> result = new List<int>();

            int[,] dp = new int[arrSize + 1, maxItemCount + 1];
            for (int i = 1; i < dp.GetLength(0); i++)
            {
                for (int j = 1; j < dp.GetLength(1); j++)
                {
                    int itemWeight = arr[i - 1].Item1;
                    int itemCount = arr[i - 1].Item2;
                    if (itemCount > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], itemWeight + dp[i - 1, j - itemCount]);
                    }
                }
            }

            int res = dp[arrSize, maxItemCount];
            if (res <= sum - res) return null;

            for (int i = arrSize; i > 0 && res > 0; i--)
            {
                //exclude scenario so should not be added
                if (res == dp[i - 1, maxItemCount])
                    continue;
               
                //include scenario so added to the list
                else
                {
                    if (arr[i - 1].Item2 > 1)
                        result.AddRange(Enumerable.Repeat(arr[i - 1].Item1/ arr[i - 1].Item2, arr[i - 1].Item2));
                    else
                        result.Add(arr[i - 1].Item1);

                    res = res - arr[i - 1].Item1;
                    maxItemCount = maxItemCount - arr[i - 1].Item2;
                }
            }
            result.Sort();
            return result;
        }
    }
}


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
    public class OptimizeBoxWeight
    {

        //For input of size n and output of size m, this approach takes O(n + m log n)
        //Space complexity O(m)
        public static List<int> GetBoxWeight(List<int> weights)
        {
            //[3,7,5,6,2] sum=23
            // 23/2 = 11

            //Heap
            //   7
            //  6  5
            //3  2
            int target = weights.Sum() / 2;

            PQ<int> pq = new PQ<int>(false);

            pq.AddAll(weights.ToArray());
            int curSum = 0;
            List<int> res = new List<int>();
            while (curSum <= target)
            {
                int val = pq.Dequeue();
                curSum += val;
                res.Insert(0, val);
            }
            return res;
        }



        //Time Complexity (n*m) n is the is the number of non repeating elements;
        //m is the  maximum size of the targeted subarray 
        //Space complexity O(n*m)
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

            //4, 5, 2, 3, 1, 2
            //(4,1)(5,1)(2*2,2)(3,1)(1,1)
            // maxItemCount=6/2-1= 2, int arrSize=5

            // Minimize  maxItemCount and maximize the itemWeight
        }

        public static List<int> Knapsack(int maxItemCount, int arrSize, List<(int, int)> arr,int sum)
        {
            //maxItemCount is the maximum size of the targeted subarray 
            // arrSize is the number of non repeating elements;

                //0 1 2 
             //0  0 0 0
             //1  0 4 4
             //2  0 5 9
             //3  0 5 9
             //4  0 5 9
             //5  0 5 9


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


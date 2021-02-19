using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class Knapsack
    {
       //Max bag size is w/ maximimize val and minimize wt.. 0/1 include or exclude
        public static int MaximizeProfit(int[] val, int[] wt, int W)
        {
            int[,] K = new int[val.Length + 1,W + 1];
            for(int i=0; i <= val.Length; i++){
            for(int j=0; j <= W; j++){
                if(i == 0 || j == 0){
                    K[i,j] = 0;
                    continue;
                }
                    //j - wt[i - 1]] + val[i - 1]  means we are including the current row value/profit ie val[i - 1].so
                    //so the current row weight is  consumed. the remaining weightt is j-wt[i-1]
                    //so we check is there any profit/value can be added with this weight from previous row
                    if (j - wt[i - 1] >= 0){
                    K[i,j] = Math.Max(K[i - 1,j], K[i - 1,j - wt[i - 1]] + val[i - 1]); 
                }else{
                    K[i,j] = K[i - 1,j]; //same column previous row
                }
            }
        }
        return K[val.Length,W];
    }
        //partition array into equal sum
        //public boolean canPartition(int[] nums)
        //{
        //    int len = nums.length;
        //    if (len == 1) return false;
        //    int sum = 0;
        //    for (int num : nums) sum += num;
        //    if (sum % 2 == 1) return false;
        //    int weight = sum / 2;
        //    int[][] dp = new int[len + 1][weight + 1];
        //    for (int i = 1; i < len + 1; i++)
        //    {
        //        for (int j = 1; j < weight + 1; j++)
        //        {
        //            int value = nums[i - 1];
        //            if (value > j)
        //            {
        //                dp[i][j] = dp[i - 1][j];
        //            }
        //            else
        //            {
        //                dp[i][j] = Math.max(dp[i - 1][j], value + dp[i - 1][j - value]);
        //            }
        //        }
        //    }

        //    return weight == dp[len][weight];
        //}
    }
}

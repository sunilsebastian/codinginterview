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
                
                if(j - wt[i - 1] >= 0){
                    K[i,j] = Math.Max(K[i - 1,j], K[i - 1,j - wt[i - 1]] + val[i - 1]); 
                }else{
                    K[i,j] = K[i - 1,j]; //same column previous row
                }
            }
        }
        return K[val.Length,W];
    }
    }
}

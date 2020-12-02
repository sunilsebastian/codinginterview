 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class CutRopeMaxProduct
    {
        public static long GetCutRopMaxProduct(int n)
        {
            int[] dp = new int[n + 1];

            dp[0] = 0;
          
            for (int i=1;i<=n;i++)
            {
                //assign this because say rodlen=3  , now 3*dp[3-3] become zero because dp[0] is zero
                dp[i] = i;
                for (int j=1;j<=i;j++)
                {
                    dp[i] = Math.Max(dp[i], j * dp[i - j]);
                }
            }

            return dp[n];

        }
    }
}

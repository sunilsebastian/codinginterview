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

            //long[] dp = new long[n + 1];

            //if (n <= 1)
            //    return 1;


            //dp[1] = 1;

            //for (int i = 2; i <= n; i++)
            //{

            //    for (int j = 1; j < i; j++)
            //    {
            //        var val = Math.Max(dp[i - j] * j, (i - j) * j);
            //        dp[i] = Math.Max(dp[i], val);
            //    }
            //}

            //return dp[n];

            long[] MP = new long[n + 1];

            MP[0] = 0;
            MP[1] = 1;
            MP[2] = 2;

            for (int i = 2; i <= n; i++)
            {
                long max = -1;
                if (i != n)
                {
                    max = i;
                }
                for (int j = 1; j < i; j++)
                {

                    max = Math.Max(max, j * MP[i - j]);
                }
                MP[i] = max;
            }
            return MP[n];

        }
    }
}

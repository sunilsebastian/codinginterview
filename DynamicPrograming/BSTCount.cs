﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class BSTCount
    {
        //refer book
        public static int NumTrees(int n)
        {

            if (n == 0 || n == 1) return 1;

            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    dp[i] += dp[k] * dp[i - k - 1];
                }
            }


            return dp[n];
        }
    }
}

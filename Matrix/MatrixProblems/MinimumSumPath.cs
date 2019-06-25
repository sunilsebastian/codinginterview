using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class MinimumSumPath
    {
        public static  int MinPathSum(int[,] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            int[,] dp = new int[m,n];
            dp[0,0] = grid[0,0];

            // initialize top row
            for (int i = 1; i < n; i++)
            {
                dp[0,i] = dp[0,i - 1] + grid[0,i];
            }

            // initialize left column
            for (int j = 1; j < m; j++)
            {
                dp[j,0] = dp[j - 1,0] + grid[j,0];
            }

            // fill up the dp table
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i, j];

                
                }
            }
            return dp[m - 1,n - 1];
        }
    }
}

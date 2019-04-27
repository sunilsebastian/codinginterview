﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class UniquePathObstacle
    {

        //[0,0,0],
        //[0,1,0],
        //[0,0,0]
        // one is an obstacle

        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            if (obstacleGrid == null || obstacleGrid.Length == 0)
                return 0;

            int m = obstacleGrid.GetLength(0);
            int n = obstacleGrid.GetLength(1);

            if (obstacleGrid[0,0] == 1 || obstacleGrid[m - 1,n - 1] == 1)
                return 0;


            int[,] dp = new int[m,n];
            dp[0,0] = 1;

            //left column
            for (int i = 1; i < m; i++)
            {
                if (obstacleGrid[i,0] == 1)
                {
                    dp[i,0] = 0;
                }
                else
                {
                    dp[i,0] = dp[i - 1,0];
                }
            }

            //top row
            for (int i = 1; i < n; i++)
            {
                if (obstacleGrid[0,i] == 1)
                {
                    dp[0,i] = 0;
                }
                else
                {
                    dp[0,i] = dp[0,i - 1];
                }
            }

            //fill up cells inside
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i,j] == 1)
                    {
                        dp[i,j] = 0;
                    }
                    else
                    {
                        dp[i,j] = dp[i - 1,j] + dp[i,j - 1];
                    }

                }
            }
            return dp[m - 1,n - 1];
        }
    }
}
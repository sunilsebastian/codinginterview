using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class MaxAreaOfIsland
    {
        public int GetMaxAreaIsland(char[,] grid)
        {
            if (grid == null || grid.GetLength(0) == 0 || grid.GetLength(1) == 0)
                return 0;

            int max = Int32.MinValue;

            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i, j] == '1')
                    {
                     
                        var curMax=merge(grid, i, j);
                        max = Math.Max(max, curMax);
                    }
                }
            }

            return count;
        }

        public int merge(char[,] grid, int i, int j)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            if (i < 0 || i >= m || j < 0 || j >= n || grid[i, j] != '1')
                return 0;

            grid[i, j] = 'X';
            int count = 1;

           count += merge(grid, i - 1, j);
           count+= merge(grid, i + 1, j);
           count+=  merge(grid, i, j - 1);
           count+=merge(grid, i, j + 1);

           return count;
        }
    }

}


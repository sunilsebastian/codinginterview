using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class NumberOfIslandscs
    {

        //11000
        //11000
        //00100
        //00011

            //Total Three Islands
        public int numIslands(char[,] grid)
        {
            if (grid == null || grid.GetLength(0) == 0 || grid.GetLength(1) == 0)
                return 0;

            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i,j] == '1')
                    {
                        count++;
                        merge(grid, i, j);
                    }
                }
            }

            return count;
        }

        public void merge(char[,] grid, int i, int j)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            if (i < 0 || i >= m || j < 0 || j >= n || grid[i,j] != '1')
                return;

            grid[i,j] = 'X';

            merge(grid, i - 1, j);
            merge(grid, i + 1, j);
            merge(grid, i, j - 1);
            merge(grid, i, j + 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{

    // https://leetcode.com/problems/unique-paths/
    public class UniquePaths
    {

        public static int GetuniquepathCount(int m, int n)
        {
            if (m == 0 || n == 0) return 0;
            if (m == 1 || n == 1) return 1;

            int[,] matrix = new int[m,n];

            //left column
            for (int i = 0; i < m; i++)
            {
                matrix[i,0] = 1;
            }

            //top row
            for (int j = 0; j < n; j++)
            {
                matrix[0,j] = 1;
            }

            //fill up the dp table
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    matrix[i,j] = matrix[i - 1,j] + matrix[i,j - 1];
                }
            }
            return matrix[m - 1,n - 1];
        }
    }
}

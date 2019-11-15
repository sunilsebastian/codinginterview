using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class NumberofWaysTocell
    {

        public static int numberOfPaths(List<List<int>> matrix)
        {
            int row = matrix.Count;
            int col = matrix[0].Count;

            int MOD = 1000000007; //(10 ^ 9 + 7)  to avoid integer overflow

            int[,] result = new int[row, col];

            bool flag = false;
            for (int i = 0; i < row; i++)
            {
                if (matrix[i][0] == 0)
                {
                    flag = true;
                }

                if (flag == false)
                {
                    result[i, 0] = 1;
                }

            }

            flag = false;
            for (int i = 0; i < col; i++)
            {
                if (matrix[0][i] == 0)
                {
                    flag = true;
                }
                if (flag == false)
                {
                    result[0, i] = 1;
                }
            }

            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    if (matrix[i][j] != 0)
                    {
                        result[i, j] = (result[i - 1, j] + result[i, j - 1]) % MOD;
                    }
                }
            }

            return result[row - 1, col - 1];
        }
    }
}

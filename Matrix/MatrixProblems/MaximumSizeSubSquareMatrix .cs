using System;

namespace MatrixProblems
{
    public class MaximumSizeSubSquareMatrix
    {
        private int Min(int a, int b, int c)
        {
            int l = Math.Min(a, b);
            return Math.Min(l, c);
        }

        public int GetMaxSize(int[,] arr)
        {
            int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
            int max = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                result[i, 0] = arr[i, 0];
                if (result[i, 0] == 1)
                {
                    max = 1;
                }
            }

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                result[0, i] = arr[0, i];
                if (result[0, i] == 1)
                {
                    max = 1;
                }
            }

            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        continue;
                    }
                    int t = Min(result[i - 1, j], result[i - 1, j - 1], result[i, j - 1]);
                    result[i, j] = t + 1;

                    if (result[i, j] > max)
                    {
                        max = result[i, j];
                    }
                }
            }
            return max;
        }
    }
}
using System;

namespace ArrayProblems
{
    public class MakeRowColumnZero
    {
        public static void SetColumRowWhenZeroFound(int[,] mat)
        {
            int rowmax = mat.GetLength(0);
            int colmax = mat.GetLength(1);

            bool[] rowArr = new bool[rowmax];
            bool[] colArr = new bool[colmax];

            for (int i = 0; i < rowmax; i++)
            {
                for (int j = 0; j < colmax; j++)
                {
                    if (mat[i, j] == 0)
                    {
                        rowArr[i] = true;
                        colArr[j] = true;
                    }
                }
            }

            for (int i = 0; i < rowmax; i++)
            {
                if (rowArr[i])
                {
                    SetRow(mat, i);
                }
            }

            for (int j = 0; j< colmax; j++)
            {
                if (colArr[j])
                {
                    SetColumn(mat, j);
                }
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", mat[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        private static void SetRow(int[,] mat, int row)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat[row, j] = 0;
            }
        }

        private static  void SetColumn(int[,] mat, int col)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                mat[i, col] = 0;
            }
        }
    }
}
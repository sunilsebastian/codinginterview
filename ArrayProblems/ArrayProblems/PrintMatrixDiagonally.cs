using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MatrixDiagonally
    {
        public static void PrintMatrixDiagonally(int[,] mat)
        {
            for(int i=0;i<mat.GetLength(0);i++)
            {
                int j = 0; //column
                int k = i; //row;
                while(j< mat.GetLength(1) && k>=0)
                {
                    Console.Write(mat[k,j]+ " ");
                    k--;
                    j ++;
                }
            }

            for (int j = 1; j < mat.GetLength(1); j++)
            {
                int i = mat.GetLength(0) - 1; //row
                int m = j; //column;
                while (m < mat.GetLength(1) && i >= 0)
                {
                    Console.Write(mat[i, m] + " ");
                    i--;
                    m++;
                }
            }

           
        }

    }
}

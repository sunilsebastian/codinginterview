using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class MaxRectSubmatrixWithOne
    {
        public static int MaxRectSubmatrixCountWithOnes(int[,] mat)
        {
            int[] temp = new int[mat.GetLength(1)];

            int max = Int32.MinValue;
            for(int i=0;i<mat.GetLength(0);i++)
            {
                for(int j=0;j<mat.GetLength(1);j++)
                {
                    if(mat[i,j]==0)
                    {
                        temp[j] = mat[i, j];
                    }
                    else
                    {
                        temp[j] += mat[i, j];

                    }
                }
                var curMax = MaxAreaHistogram.GetMaxHistogram(temp);
                max = Math.Max(max, curMax);
            }

            return max;

        }
    }
}

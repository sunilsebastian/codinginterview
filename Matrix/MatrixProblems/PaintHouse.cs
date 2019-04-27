using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class PaintHouse
    {
        public static int GetMinCost(int[,] mat)
        {
            if (mat == null || mat.GetLength(0) == 0 || mat.GetLength(1) == 0)
                return 0;

            for( int i=1;i<mat.GetLength(1);i++)
            {
                mat[i,0]+=Math.Min(mat[i-1,1],mat[i-1,2]);
                mat[i, 1] += Math.Min(mat[i - 1, 0], mat[i - 1, 2]);
                mat[i, 2] += Math.Min(mat[i - 1, 0], mat[i - 1, 1]);
            }
            return Math.Min(Math.Min(mat[mat.GetLength(0)-1,0], mat[mat.GetLength(0) - 1, 1]), mat[mat.GetLength(0) - 1, 2]);
        }
    }
}

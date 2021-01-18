using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    //https://leetcode.com/problems/paint-house/
    public class PaintHouse
    {
        //     R   G   B
        //H1 { 17, 2, 17},
        //H2 { 16, 16, 5},
        //H3 { 14,  3, 19}

        //keep the first row of the matrix as is because  we can choose any color for H1

        // if we want to kepp RED  for House2  I would have choosen Blue or Green for House 1 whichever has 
        //the minimum value  as we cannot paint adjecent houses with same color.

        // if we want to keep Green  for House2  I would have choosen Red or Blue for House 1 whichever has 
        //the minimum value  as we cannot paint adjecent houses with same color.

        // if we want to keep blue  for House2  I would have choosen Red or green for House 1 whichever has 
        //the minimum value  as we cannot paint adjecent houses with same color.


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
            return Math.Min(Math.Min(mat[mat.GetLength(0)-1,0], mat[mat.GetLength(0) - 1, 1]),
                mat[mat.GetLength(0) - 1, 2]);
        }
    }
}

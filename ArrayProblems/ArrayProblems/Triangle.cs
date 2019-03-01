using System;
using System.Collections.Generic;

namespace ArrayProblems
{
    public class Triangle
    {
        // [1,0]=[1,0]+Min([2,0],[2,1])
        // [1,1]=[1,1]+ Min([2,1],[2,2])

        public static int MinSum(List<List<int>> triangle)
        {
            for (var i = triangle.Count - 1; i > 0; i--)
                for (var j = 0; j < triangle[i].Count - 1; j++)
                    triangle[i - 1][j] += Math.Min(triangle[i][j], triangle[i][j + 1]);
            return triangle[0][0];
        }

    }
}

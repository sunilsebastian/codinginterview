using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblems
{
    public class SearchSorted2DMatrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null) return false;

            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

              if(row == 0 || column == 0)
                return false;

            int start = 0;
            int end = row * column - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                int midX = mid / column;
                //for 
                int midY = mid % column;

                if (matrix[midX,midY] == target)
                    return true;

                if (matrix[midX,midY] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return false;
        }
    }
}

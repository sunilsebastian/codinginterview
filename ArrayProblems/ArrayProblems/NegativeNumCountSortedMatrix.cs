using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class NegativeNumCountSortedMatrix
    {
        public static int GetNegativeNumCountSortedMatrix(int[,] arr)
        {
            int numberOfRows = arr.GetLength(0);
            int numberOfColumns = arr.GetLength(1);
            int count = 0;

            int i = 0;
            int j = numberOfColumns - 1;

             while (i< numberOfRows && j>=0)
             {
                if (arr[i, j] < 0)
                {
                    count += (j + 1);
                    i++;
                }
                else
                {

                    j--;
                }
             }

            return count;
        }

    }
}

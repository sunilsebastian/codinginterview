using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public  class SubsetSum
    {
        public static bool IsSubsetSum1(int[] set, int sum)
        {
            int m = set.Length;
          
            bool[,] subset = new bool[m+1, sum + 1];

            // If sum is 0, then answer is true because we can make up this sum with an empty set.
            for (int i = 0; i <= m; i++)
                subset[i, 0] = true;

            // Fill the subset table in bottom up manner 
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    subset[i, j] = subset[i-1, j];
                    if (j-set[i - 1]>=0)
                        subset[i, j] = subset[i, j] ||
                                       subset[i-1,j - set[i - 1]];
                }
            }
            return subset[m,sum];
        }

    }
}

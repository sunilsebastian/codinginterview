using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public  class LargestContinousSum
    {
        public static int GetLargestContinousSum(int[] values)
        {
            int currMax = values[0];
            int max = values[0];

            for(int i=1;i<values.Length;i++)
            {
                currMax = Math.Max(values[i], values[i] + currMax);
                max = Math.Max(currMax, max);
            }
            return max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class CuttingRod
    {
        public static int GetmaxValue(int[] prices,int len)
        {
            int[] max = new int[len + 1];
            for (int i = 1; i <= len; i++)
            {
                for(int j=1;j<=prices.Length;j++)
                {
                    if (i < j)
                        continue;
                    max[i] = Math.Max(max[i], max[i-j] + prices[j-1]);
                }
            }
            return max[len];
        }
    }
}

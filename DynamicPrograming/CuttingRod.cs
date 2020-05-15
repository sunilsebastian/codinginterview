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
            for (int rodLen = 1; rodLen <= len; rodLen++)
            {
                for(int size=1;size<=prices.Length;size++)
                {
                    if (rodLen < size)
                        continue;
                    max[rodLen] = Math.Max(max[rodLen], max[rodLen - size] + prices[size-1]);
                }
            }
            return max[len];
        }
    }
}

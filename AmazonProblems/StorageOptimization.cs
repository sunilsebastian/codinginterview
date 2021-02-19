using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class StorageOptimization
    {

        private int getMax(int dim, HashSet<int> set)
        {
            int maxHere = 0, maxTotal = 0;
            for (int i = 0; i <= dim; i++)
            {
                maxHere++;
                maxTotal = Math.Max(maxTotal, maxHere);
                if (!set.Contains(i + 1))
                {
                    maxHere = 0;
                }
            }
            return maxTotal;
        }
        private int findMaxVolume(int n, int m, int[] h, int[] v)
        {
            //n row
            //m column

            // h horizontal partition ==>row
            //v vertical partiton ==>column 
            HashSet<int> colSet = new HashSet<int>();
            HashSet<int> rowSet = new HashSet<int>();
            foreach (int num in  h) rowSet.Add(num);
            foreach (int num in v) colSet.Add(num);

            int maxWidth = getMax(n, rowSet), maxHeight = getMax(m, colSet);
            return maxHeight * maxWidth;
        }
    }
}

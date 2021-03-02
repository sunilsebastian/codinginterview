using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class StorageOptimization
    {

        private static int getMax(int dim, HashSet<int> set)
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
        public static   int findMaxVolume(int n, int m, int[] h, int[] v)
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


        #region algo monster

       // Sorting the array takes O(|h| * log(|h|)) time, and going through the sorted array
       // to find the largest gap takes O(|h|) time.The auxiliary space required is constant 
       //if we modify the input arrays; otherwise O(|h|) is needed to store the sorted values.Note that 
       //if the input array h is already sorted, this is a strictly better solution. If not, it will depend on the size of h and the value of n.
       //The less percentage of the separators removed (i.e.the more sparse the "removed separators" are), the more efficient this approach is compared to the previous one.
        public  static int GetLongest(List<int> arr)
        {
            arr.Sort();
            int prev = -1;
            int currMax = 0;
            int max = 0;
            foreach (var val in  arr)
            {
                if (val != prev + 1)
                    currMax = 0;
                prev = val;
                currMax++;
                max = Math.Max(currMax, max);
            }
            return max;
        }
        public static int storageOptimization(int n, int m, List<int> h, List<int> v)
        {
            return (GetLongest(h) + 1) * (GetLongest(v) + 1);
        }
        #endregion


    }
}

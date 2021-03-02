using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonProblems
{
    public class ItemsInContainers
    {
         //          0123456
        //Input: s = |**|*|*, ranges = [[0, 4], [1, 6]]
        public static List<int> numberOfItems(String s, List<List<int>> ranges)
        {
            
            int n = s.Length;

            //add  (index,number of "*" ) when there is a "|"
            Dictionary<int, int> prefixSums = new Dictionary<int, int>();
            int curSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '|')
                    prefixSums.Add(i, curSum);
                else
                    curSum++;
            }

            //go forwrard and copy the "|" index till find another
            int[] leftBounds = new int[n];
            int last = -1;
            for (int i = 0; i < n; i++)
            {
                if (s[i]== '|')
                    last = i;
                leftBounds[i] = last;
            }

            //go backward and copy the "|" index till find another.
            int[] rightBounds = new int[n];
            last = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (s[i] == '|')
                    last = i;
                rightBounds[i] = last;
            }

            //find dif and get value from dict
            List<int> res = new List<int>();
            for (int i = 0; i < ranges.Count; i++)
            {
                int start = rightBounds[ranges[i][0]];
                int end = leftBounds[ranges[i][1]];
                 if (start != -1 && end != -1 && start < end)
                    res.Add(prefixSums[end] - prefixSums[start]);
                else
                    res.Add(0);
            }
            return res;
        }

      
    }
}

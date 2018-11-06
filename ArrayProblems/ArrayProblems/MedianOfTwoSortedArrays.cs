using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MedianOfTwoSortedArrays
    {
       public  static int getMedian(int[] ar1, int[] ar2, int n)
        {
            int i = 0;
            int j = 0;
            int count;
            int prev = -1, current = -1;

            //if you travel n+1 you will be at n+1 th element

            for (count = 0; count <= n; count++)
            {
             
                if (i == n)
                {
                    prev = current;
                    current = ar2[0];
                    break;
                }

                else if (j == n)
                {
                    prev = current;
                    current = ar1[0];
                    break;
                }

                if (ar1[i] < ar2[j])
                {
                    // Store the prev median  
                    prev = current;
                    current = ar1[i];
                    i++;
                }
                else
                {
                    // Store the prev median  
                    prev = current;
                    current = ar2[j];
                    j++;
                }
            }

            return (current + prev) / 2;
        }
    }
}

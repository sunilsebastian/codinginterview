using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MaxRepeatingElementInArray
    {
        public static int FindMaxRepeatingElementInAnArray(int[] arr, int k)
        {
            //0 to N contain elements such that K --> should be 0 to N-1
            int maxRepeating = 0;
            int index = 0;

            for(int i=0;i<arr.Length;i++)
            {
                arr[arr[i]%k]+=k;
            }

            for( int i=0;i<arr.Length;i++)
            {
                if (arr[i] > maxRepeating)
                {
                    maxRepeating = arr[i];
                    index = i;
                }

            }

            return index;

        }
    }
}

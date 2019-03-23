using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MissingPositiveNumber
    {
        public static int FindFirstMissingPositiveNumber(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                // when the ith element is not i
                while (arr[i] != i)
                {
                    // no need to swap when ith element is out of range [0,n]
                    if (arr[i] < 0 || arr[i] >= n)
                        break;

                    //handle duplicate elements
                    if (arr[i] == arr[arr[i]])
                        break;
                    // swap elements
                    int temp = arr[i];
                    arr[i] = arr[temp];
                    arr[temp] = temp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != i)
                    return i;
            }

            return n;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MergeAndMeadian
    {
        public  static int[] MergeArrays(int[] arr1, int[] arr2, int[] arr3)
        {
            List<int[]> arrays = new List<int[]>();
            arrays.Add(arr1);
            arrays.Add(arr2);
            arrays.Add(arr3);

            if (arrays == null || arrays.Count == 0)
                return null;
            int[] p, q;
            if (arrays.Count >= 2)
            {
                p = arrays[0];
                for (int i = 1; i < arrays.Count; i++)
                {
                    p = Merge2Arrays(p, arrays[i]);
                }
            }
            else
            {
                return arrays[0];
            }
            return p;

        }

        private static int[] Merge2Arrays(int[] arr1, int[] arr2 )
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = arr1.Length - 1;
            int j = arr2.Length - 1; ;
            int resultIndex = result.Length - 1;
            while (i >= 0 && j >= 0)
            {
                if (arr1[i] > arr2[j])
                {
                    result[resultIndex--] = arr1[i--];

                }
                else if (arr1[i] < arr2[j])
                {
                    result[resultIndex--] = arr2[j--];


                }
                else
                {
                    result[resultIndex--] = arr1[i--];
                    result[resultIndex--] = arr2[j--];

                }
            }

            while (i >= 0)
            {
                result[resultIndex--] = arr1[i--];

            }
            while (j >= 0)
            {
                result[resultIndex--] = arr2[j--];

            }

            return result;
        }
    }

}

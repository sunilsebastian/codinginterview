using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class InterSectionOfSortedArray
    {
        public static void PrintIntersection(int[] arr1,int[] arr2, int m, int n)
        {
            int i = 0, j = 0;

            while (i < m && j < n)
            {
                if (arr1[i] < arr2[j])
                    i++;
                else if (arr2[j] < arr1[i])
                    j++;
                else
                {
                    Console.Write(arr2[j++] + " ");
                    i++;
                }
            }
        }
    }
}

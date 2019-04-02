using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class UnionOfTwoSortedArrays
    {
        public static void PrintUnion(int[] arr1, int[] arr2)
        {

            //Difference between and union and intersecttion
            //union has to keep the previous element to check for duplicate
            //always check its not equal to prev befre printing the element

            //When both elements are equal union and intersection  take one and increment both i and j
            //but while merging arrays it takes both i and j and increment both i and j
           
            //median take i or j but incement whichever is taken.


            int n1 = arr1.Length;
            int n2 = arr2.Length;
            int i = 0;
            int j = 0;
            int prev = -1;
            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                {
                    if (prev != arr1[i])
                    {
                        Console.Write(arr1[i] + " ");
                        prev = arr1[i];
                    }
                    i++;
                }

                else if (arr2[j] < arr1[i])
                {
                    if (prev != arr2[j])
                    {
                        Console.Write(arr2[j] + " ");
                        prev = arr1[j];
                    }
                    j++;
                }

                else
                {
                    if (prev != arr1[i])
                    {
                        Console.Write(arr1[i] + " ");
                        prev = arr1[i];
                    }
                    i++;
                    j++;

                }
            }

            while (i < n1)
            {
                if (prev != arr1[i])
                {
                    Console.Write(arr1[i] + " ");
                    prev = arr1[i];
                }
                i++;
            }
            while (j < n2)
            {
                if (prev != arr2[j])
                {
                    Console.Write(arr2[j] + " ");
                    prev = arr2[j];
                }
                j++;
            }

        }
    }
}

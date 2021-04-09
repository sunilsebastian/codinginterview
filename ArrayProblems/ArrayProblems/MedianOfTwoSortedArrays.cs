using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MedianOfTwoSortedArrays
    {
        public static int getMedian(int[] ar1, int[] ar2, int n)
        {
            int i = 0;
            int j = 0;
            int count;
            int prev = -1, current = -1;

            // go beyond n-1 so that last element become previous
            for (count = 0; count <= n; count++)
            {
                // if all elements of First arry is lesser than all aelements of second array 
                if (i == n)
                {
                    prev = current;
                    current = ar2[0];
                    break;
                }

                // if all elements of second arry is lesser than all aelements of first array 
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

        public static double getMedian1(int[] nums1, int[] nums2)
        {

            if (nums1.Length == 0 && nums2.Length == 0) return 0d;

            int length = nums1.Length + nums2.Length;
            bool isOdd = length % 2 == 1;


            int mid = length / 2;

            int p1 = 0, p2 = 0;

            //additional counter
            int count = 0;

            int prev = -1;
            int current = -1;

            while (count <= mid)
            {
                prev = current;
                //write the second condition in OR first then write the opposite arr condition in first part of OR
                if (p2 == nums2.Length || (p1 < nums1.Length && nums1[p1] <= nums2[p2]))
                {
                    current = nums1[p1];
                    p1++;
                }
                else
                {
                    current = nums2[p2];
                    p2++;
                }
                count++;
            }

            if (isOdd)
            {
                return current;
            }
            else
            {
                return (prev + current) / 2d;
            }

        }
    }
}

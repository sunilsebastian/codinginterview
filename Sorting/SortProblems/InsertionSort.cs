using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class InsertionSort
    {
        public static int[] Sort(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                int temp = arr[i];
                int j = i;

                while(j>0 && arr[j-1]>temp)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
            return arr;
        }
    }
}

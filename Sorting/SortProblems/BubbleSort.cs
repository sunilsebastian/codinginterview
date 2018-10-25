using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProblems
{
    public class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            bool freePass = false;

            for (int i = 0; i < arr.Length && !freePass; i++)
            {
                freePass = true;
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        freePass = false;
                    }

                }
            }
            return arr;
        }
 
    }
}

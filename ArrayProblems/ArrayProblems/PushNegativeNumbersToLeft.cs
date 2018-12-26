using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class PushNegativeNumbersToLeft
    {
        public static void PushNegativeNumbers(int[] arr)
        {
            int i = -1;
           
            for( int j=0;j< arr.Length;j++)
            {
                if(arr[j]<0)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            for (int k = 0; k < arr.Length; k++)
                Console.Write(arr[k] + " ");
        }
    }
}

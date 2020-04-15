using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ArrayInWaveForm
    {
        public static  int[] GetWaveForm(int[] arr)
        {
            Array.Sort(arr);

            for( int i=0;i<arr.Length-1;i=i+2)
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }

            return arr;
        }
    }
}

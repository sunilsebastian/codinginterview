using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ArrayInWaveForm
    {

        //arrange the elements into a sequence such that a1 >= a2 <= a3 >= a4 <= a5.....
        //swap each pairs 1 2 3 4 5 6  swap(12) swap(34) swap(56)
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

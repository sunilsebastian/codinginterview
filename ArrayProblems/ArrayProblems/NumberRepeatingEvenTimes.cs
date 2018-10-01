using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public  class NumberRepeatingEvenTimes
    {
        public static void FindNumberRepeatingEvenTimes(int[] arr)
        {
            long  _xor = 0L;
            long  pos;
            int n = arr.Length;

            // do for each element of array 
            for (int i = 0; i < n; ++i)
            {
                // right pos 1 by value of current element 
                pos = 1 << arr[i];

                // Toggle the bit everytime element gets repeated 
                _xor ^= pos;
            }

            // Traverse array again and use _xor to find even 
            // occuring elements 
            for (int i = 0; i < n; ++i)
            {
                // right shift 1 by value of current element 
                pos = 1 << arr[i];

                // Each 0 in _xor represents an even occurrence 
                if ((pos & _xor)==0)
                {
                    // print the even occurring numbers 
                    Console.Write(arr[i] +" ");

                    // set bit as 1 to avoid printing duplicates 
                    _xor ^= pos;
                }
            }
        }

    }
}

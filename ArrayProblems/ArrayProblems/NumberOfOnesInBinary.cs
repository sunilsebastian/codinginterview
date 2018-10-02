using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class NumberOfOnesInBinary
    {
        public static int CountOnesInBinary(int n)
        {
            int count = 0;
            if (n == 0)
                return 0;

           while(n>0)
            {
               var result = n & 1;
                if (result == 1) count++;
                n = n >> 1;
            }

            return count;
        }

    }
}

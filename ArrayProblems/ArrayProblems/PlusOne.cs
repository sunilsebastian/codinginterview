using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public  class PlusOneTest
    {
        public static  int[] PlusOne(int[] digits)
        {

         for(int i= digits.Length-1; i>=0;i--)
            {
                if(digits[i]<9)
                {
                    digits[i] ++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;

        }
    }
}

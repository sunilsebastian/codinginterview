using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            bool neg = false;
            if (x < 0)
            {
                neg = true;
                x = -x;
            }

            long num = 0;
            while (x > 0)
            {

                int carry = x % 10;
                x = x / 10;

                num = num * 10;
                num = num + carry;
            }

            if (num > Int32.MaxValue || num < Int32.MinValue)
            {
                return 0;
            }


            if (neg == true)
                num = -num;
            return (int)num;
        }
    }
}

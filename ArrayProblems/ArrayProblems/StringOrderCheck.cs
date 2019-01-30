using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class StringOrderCheck
    {
        public static bool IsStringsAreInOrder(string str1, string str2, string str3)
        {
            int Count1 = 0;
            int Count2 = 0;
            int Count3 = 0;

            if (str1.Length + str2.Length != str3.Length)
            {
                return false;
            }
            while (Count3 < str3.Length)
            {

                if ( Count1 < str1.Length && str1[Count1] == str3[Count3])
                {

                    Count1++;

                }

                else if ( Count2 < str2.Length && str2[Count2] == str3[Count3])
                {
                    Count2++;

                }
                else
                {
                    return false;
                }

                Count3++;
            }
            return true;
        }
    }
}

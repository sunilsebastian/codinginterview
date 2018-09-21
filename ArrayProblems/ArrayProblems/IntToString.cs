using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class IntToString
    {
        public static string Convert(int n)
        {
           StringBuilder numString = new StringBuilder();
            int num =n;
            do
            {
                char digit = (char)((num % 10)+'0');
                num = num / 10;
                numString.Insert(0, digit);
            } while (num > 0);

            return numString.ToString();
        }
    }
}

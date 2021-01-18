using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class StringToInt
    {
        public static int Convert(string str)
        {
            int index = 0;
            double sum = 0;
            bool isNegative = false;
            str = str.Trim();
            if (str == null || str == string.Empty)
            {
                return 0;
            }
            int sign = 1;
            if (str[0] == '-')
            {
                isNegative = true;
                sign = -1;
                index = 1;

            }
            if (str[0] == '+')
            {
                index = 1;
            }
            while (index < str.Length)
            {
                if (!Char.IsDigit(str[index])) break;
                sum = sum * 10 + str[index] - '0';
                if (isNegative == false && sum > int.MaxValue)
                    return int.MaxValue;
                index++;
            }
            return (int)sum * sign;
        }
    }
}

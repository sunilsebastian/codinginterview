using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class IntToString
    {
        public static string IntToString(int num)
        {
            if (num == 0) return "0";
        
            bool negative = num < 0;
            if (negative) num = -num;
        
            StringBuilder sb = new StringBuilder();
        
            while (num > 0)
            {
                int digit = num % 10;
                sb.Append((char)(digit + '0'));
                num /= 10;
            }
        
            if (negative)
                sb.Append('-');
        
            char[] arr = sb.ToString().ToCharArray();
            Array.Reverse(arr);
        
            return new string(arr);
        }
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

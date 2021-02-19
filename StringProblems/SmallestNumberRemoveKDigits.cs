using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class SmallestNumberRemoveKDigits
    {
        public static string RemoveKdigits(string num, int k)
        {
            if (num.Length == k) { return "0"; }
            if (num.Length == 0) { return num; }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num.Length; i++)
            {
      
                while (k > 0 && sb.Length > 0 && sb[sb.Length - 1] > num[i])
                {
                    sb.Remove(sb.Length - 1, 1);
                    k--;
                }

                //when first character is zero or repeated zeros ignore
                //or cases like 10200 k=1

                if (sb.Length == 0 && num[i] == '0')
                    continue;
                else
                    sb.Append(num[i]);

            }
            //case 123456  k=1  nothing will be removed so do this
            return sb.Length - k > 0 ? sb.ToString(0, sb.Length - k) : "0";
        }

       
    }
}


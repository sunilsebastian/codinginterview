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

                if (sb.Length != 0 ||num[i] != '0')
                {
                    sb.Append(num[i]);
                }
            }

            return sb.Length - k > 0 ? sb.ToString(0, sb.Length - k) : "0";
        }

       
    }
}


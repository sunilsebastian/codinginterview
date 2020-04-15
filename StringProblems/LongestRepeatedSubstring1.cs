using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class LongestRepeatedSubstring1
    {
        public static string getLongestRepeatedSubstring(string inputStr)
        {

            // form the N suffixes
            int N = inputStr.Length;
            String[] suffixes = new String[N];
            for (int i = 0; i < N; i++)
            {
                suffixes[i] = inputStr.Substring(i, N - i);
            }

            // sort them
            Array.Sort(suffixes);

            String lrs = "";
            for (int i = 0; i < N - 1; i++)
            {
                String x = GetCommonPrefix(suffixes[i], suffixes[i + 1]);
                if (x.Length > lrs.Length)
                    lrs = x;
            }
            return lrs;
        }

        public static String GetCommonPrefix(String s, String t)
        {
            int n = Math.Min(s.Length, t.Length);
            for (int i = 0; i < n; i++)
            {
                if (s[i] != t[i])
                    return s.Substring(0, i);
            }
            return s.Substring(0, n);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class BackspaceStringCompare
    {

        public static bool BackspaceCompare(string S, string T)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            int i = S.Length - 1;
            int j = T.Length - 1;

            int count = 0;
            while (i >= 0)
            {
                if (S[i] == '#') { count++; }
                else
                {
                    if (count > 0) { count--; }
                    else
                    { sb1.Insert(0, S[i]); }
                }
                i--;
            }

            count = 0;
            while (j >= 0)
            {
                if (T[j] == '#') { count++; }
                else
                {
                    if (count > 0) { count--; }
                    else
                    {
                        sb2.Insert(0, T[j]);

                    }
                }
                j--;
            }
            if (sb1.ToString() != sb2.ToString()) return false;
            return true;
        }
    }
}

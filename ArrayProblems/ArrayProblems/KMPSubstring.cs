using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{

    //KMP suffix also a prefix
    //abxabcabcaby //abcaby
    //abcbcglx //bcgl
   // Knuth–Morris–Pratt(KMP)
    public class KMPSubstring
    {
       // O(mn)
        public static bool SubStringExists(string text, string pattern)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i<text.Length && j<pattern.Length)
            {
                if(text[i]==pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = 0;
                    k++;
                    i = k;
                }
            }

            if (j == pattern.Length)
                return true;
            return false;
        }

       // O(m+n)
        public static bool KMPSubstringExists(string text, string pattern)
        {
            var tempArr = GetTempArray(pattern);
            int i = 0;
            int j = 0;

            while(i< text.Length && j< pattern.Length)
            {
                if(text[i]== pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if(j==0)
                    {
                        i++;
                    }
                    else
                    {
                        j = tempArr[j - 1];

                    }
                }
            }
            if (j == pattern.Length)
                return true;
            return false;
        }

        // Compute temporary array to maintain size of suffix which is same as prefix
        private static  int[] GetTempArray(string pattern)
        {
            int j = 0;
            int[] tempArr = new int[pattern.Length];
            for(int i=1;i<pattern.Length;i++)
            {
                if(pattern[i]==pattern[j])
                {
                    tempArr[i] =j + 1;
                    i++;
                    j++;
                }
                else
                {
                    if(j==0)
                    {
                        i++;
                    }
                    else
                    {
                        j = tempArr[j - 1];
                    }
                }
            }
            return tempArr;
        }


    }
}

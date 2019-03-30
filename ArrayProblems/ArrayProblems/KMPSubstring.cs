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
            int j = 0;
            int i = 0;
            int k = 0;
            while (j<text.Length && i<pattern.Length)
            {
                if(text[j]==pattern[i])
                {
                    j++;
                    i++;
                }
                else
                {
                    i = 0;
                    k++;
                    j = k;
                }
            }

            if (i == pattern.Length)
                return true;
            return false;
        }

       // O(m+n)
        public static bool KMPSubstringExists(string text, string pattern)
        {
            var tempArr = GetTempArray(pattern);
            int j = 0;
            int i = 0;
            
           //i is the pattern index
           //j is the work index

            while(j< text.Length && i< pattern.Length)
            {
                if(text[j]== pattern[i])
                {
                    j++;
                    i++;
                }
                else
                {
                    if(i==0)
                    {
                        j++; 
                    }
                    else
                    {
                        i = tempArr[i - 1];  //rest the pattern index to  wo

                    }
                }
            }
            if (i == pattern.Length)
                return true;
            return false;
        }

        // Compute temporary array to maintain size of suffix which is same as prefix
        private static  int[] GetTempArray(string pattern)
        {
            int i = 0;
            int j = 1;
            int[] tempArr = new int[pattern.Length];
            while(j< pattern.Length)
            {
                if(pattern[j]==pattern[i])
                {
                    tempArr[j] =i + 1;
                    j++;
                    i++;
                }
                else
                {
                    if(i==0)
                    {
                        j++;
                    }
                    else
                    {
                        i = tempArr[i - 1];
                    }
                }
            }
            return tempArr;
        }


    }
}

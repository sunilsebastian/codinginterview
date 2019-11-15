using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class RabinKarpSubstringSearch
    {
       
        public static int[] SearchString(string text, string pattern)
        {
            List<int> retVal = new List<int>();



            ulong textHash = 0;
            ulong patternHash = 0;
            ulong moduloConst = 100007;
            ulong hashConst = 3;//256;

            for (int i = 0; i < pattern.Length; ++i)
            {
                textHash = (textHash * hashConst + (ulong)text[i]) % moduloConst;
                patternHash = (patternHash * hashConst + (ulong)pattern[i]) % moduloConst;
            }

            if (textHash == patternHash)
                retVal.Add(0);

            ulong pow = 1;

            //this is the power of the out going element . the fisrt element in previous window
            //patern length is 3 . pow it will be Pow(hashConst,len-1) ie Pow(3,2) --> 3*3
            //patern length is 4 . pow it will be Pow(hashConst,len-1) ie Pow(3,3) --> 3*3*3

            for (int k = 1; k <= pattern.Length - 1; ++k)
                pow = (pow * hashConst) % moduloConst;


            for (int j = 1; j <= text.Length - pattern.Length; ++j)
            {
                //textHash = (textHash + moduloConst - pow * (ulong)text[j - 1] % moduloConst) % moduloConst;

                //Here textHash  is value of previous window of text
                //pow * (ulong)text[j - 1]   is the value of outgoing letter from previous window
                textHash = (textHash - pow * (ulong)text[j - 1] % moduloConst) % moduloConst;

                //(ulong)text[j + pattern.Length - 1]  is the last char of new window or the only new char in current window
                textHash = (textHash * hashConst + (ulong)text[j + pattern.Length - 1]) % moduloConst;

                if (textHash == patternHash)
                    if (text.Substring(j, pattern.Length) == pattern)
                        retVal.Add(j);
            }

            return retVal.ToArray();
        }




    }
}

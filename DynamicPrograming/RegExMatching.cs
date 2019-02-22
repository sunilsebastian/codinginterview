using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class RegExMatching
    {
        //* means 0 or more occurences of a character before k
        //.means exactly matching any single char

        public static bool StringMatch(String str, String pattern,
                               int n, int m)
        {
            n = str.Length;
            m = pattern.Length;
            // empty pattern can only match with 
            // empty string 
            if (m == 0)
                return (n == 0);

            // lookup table for storing results of 
            // subproblems 
            bool[,] Lookup = new bool[n + 1, m + 1];


            // empty pattern can match with empty string 
            Lookup[0, 0] = true;

            // Only '*' can match with empty string 
            for (int j = 1; j <= m; j++)
                if (pattern[j - 1] == '*')
                    Lookup[0, j] = Lookup[0, j - 2];

            // fill the table in bottom-up fashion 
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {

                      // Current characters are considered as 
                    // matching in two cases 
                    // (a) current character of pattern is '?' 
                    // (b) characters actually match 
                   if (pattern[j - 1] == '.' ||
                        str[i - 1] == pattern[j - 1])
                        Lookup[i, j] = Lookup[i - 1, j - 1];

                    //xa* pattern
                    //xa  string

                    //  Lookup[i,j] = Lookup[i,j - 2]; means  x and Xa doesnt match
                    //pattern[j - 2] == str[i - 1] means xa* and xa match( a==a)  xa* to X

                    else if (pattern[j - 1] == '*')
                    {

                        Lookup[i,j] = Lookup[i,j - 2];
                        if (pattern[j - 2] == '.' || pattern[j - 2] == str[i - 1])
                        {
                            Lookup[i,j] = Lookup[i,j] || Lookup[i - 1,j];
                        }
                   
                    }



                    // If characters don't match 
                    else Lookup[i, j] = false;
                }
            }

            return Lookup[n, m];
        }
    }
}

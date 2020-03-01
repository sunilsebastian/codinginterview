using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class LengthOfLongestSubstringKDistinct
    {

        public static int GetLengthOfLongestSubstringKDistinct(String s, int k)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int maxLen = 0;
            int currLen = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i], 1);
                }


                if (dict.Count > k)
                {

                    char charToRemove = s[i - currLen];
                    int charToRemoveCount = dict[charToRemove];
                    if (charToRemoveCount == 1)
                        dict.Remove(charToRemove);
                    else
                        dict[charToRemove]--;
                       
                }
                else
                {
                    currLen++;
                    maxLen = Math.Max(currLen, maxLen);
                }
            }
            return maxLen;
        }

      

    }
}

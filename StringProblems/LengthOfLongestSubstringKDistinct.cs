using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class LengthOfLongestSubstringKDistinct
    {

        public static int GetLengthOfLongestSubstringKDistinct1(int[] s, int k)
        {
            int result = 0;
            int i = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int j = 0; j < s.Length; j++)
            {
                var c = s[j];
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }

                if (dict.Count <= k)
                {
                    result = Math.Max(result, j - i + 1);
                }
                else
                {
                    while (dict.Count > k)
                    {
                        var l = s[i];
                        int count = dict[l];
                        if (count == 1)
                        {
                            dict.Remove(l);
                        }
                        else
                        {
                            dict[l]--;
                        }
                        i++;
                    }
                }

            }
            return result;
        }

        //abcbbbbcccbdddadacb
        //bcbbbbcccb
        public static  int GetLengthOfLongestSubstringKDistinct(String s, int k)
        {
            int result = 0;
            int i = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int j = 0; j < s.Length; j++)
            {
                char c = s[j];
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }

                if (dict.Count <= k)
                {
                    result = Math.Max(result, j - i + 1);
                }
                else
                {
                    while (dict.Count > k)
                    {
                        char l = s[i];
                        int count = dict[l];
                        if (count == 1)
                        {
                            dict.Remove(l);
                        }
                        else
                        {
                            dict[l]--;
                        }
                        i++;
                    }
                }

            }
            return result;
        }

    }
}

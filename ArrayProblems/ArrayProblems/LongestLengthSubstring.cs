using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    //logest substring without repeating characters
    //sliding window
    public class LongestLengthSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }

            HashSet<Char> set = new HashSet<Char>();
            int result = 1;
            int i = 0;
            for (int j = 0; j < s.Length; j++)
            {
                char c = s[j];
                if (!set.Contains(c))
                {
                    set.Add(c);
                    result = Math.Max(result, set.Count);
                }
                else
                {
                    while (i < j)
                    {
                        if (s[i] == c)
                        {
                            i++;
                            break;
                        }

                        set.Remove(s[i]);
                        i++;
                    }
                }
            }

            return result;
        }
    }
}

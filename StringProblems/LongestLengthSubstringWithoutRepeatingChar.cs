using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    //logest substring without repeating characters
    //sliding window
    public class LongestLengthSubstringWithoutRepeatingChar
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }

            HashSet<Char> set = new HashSet<Char>();
            int max = 0;
            int i = 0;
            int j = 0;
            while(j<s.Length)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                    max = Math.Max(max, set.Count);
                }
                else
                {
                    set.Remove(s[i]);
                    i++;
                }
            }

            return max;
        }

        public static int LengthOfLongestSubstring1(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }

            HashSet<Char> set = new HashSet<Char>();
            int max = 0;
            int left = 0;
            int right = 0;
            string longest = string.Empty;
            while (right < s.Length)
            {
                if (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);
                string str = s.Substring(left, right - left + 1);
                if(str.Length>max)
                {
                    max = str.Length;
                    longest = str;
                }

                right++;
               
            }

            return max;
        }
    }
}

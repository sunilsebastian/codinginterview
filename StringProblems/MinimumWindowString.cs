using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    public class MinimumWindowString
    {


        public static string GetMinWindow(string s, string t)
        {
            int left = 0;
            int missing = 0;
            string shortestString = string.Empty;
            string result = string.Empty;
            int shortest = int.MaxValue;

            Dictionary<char, int> dict = new Dictionary<char, int>();


            for (int i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]))
                {
                    dict[t[i]]++;
                }
                else
                {
                    dict.Add(t[i], 1);
                }
            }
           
            for (int right = 0; right < s.Length; right++)
            {
                if (dict.ContainsKey(s[right]))
                {
                    dict[s[right]]--;

                    if (dict[s[right]] >= 0)
                    {
                        missing++;
                    }


                }
                while (missing == t.Length)
                {
                    if (right - left + 1 < shortest)
                    {
                        shortest = right - left + 1;
                        shortestString = s.Substring(left, shortest);
                        result = shortestString;
                    }

                    if (dict.ContainsKey(s[left]))
                    {
                        dict[s[left]]++;
                        if (dict[s[left]] > 0)
                            missing--;
                    }
                    left++;

                }

            }
            return result;
        }



        // Function to find smallest window containing 
        // all characters of 'pat' 
        public static String findSubString(String s, String t)
        {
            string res = string.Empty;
            if (t.Length > s.Length) return res;
            if (t.Equals(s)) return s;

            var dict = new Dictionary<char, int>();
            for (var i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]))
                    dict[t[i]]++;
                else
                    dict.Add(t[i], 1);
            }

            int left = 0, shortestWindowLength = s.Length, count = 0;
            for (int right = 0; right < s.Length; right++)
            {
                if (dict.ContainsKey(s[right]) && --dict[s[right]] >= 0)
                    count++;

                while (count == t.Length)
                {
                    if (shortestWindowLength > right - left)
                    {
                        shortestWindowLength = right - left;
                        res = s.Substring(left, shortestWindowLength + 1);
                    }
                    if (dict.ContainsKey(s[left]) && ++dict[s[left]] > 0)
                        count--;
                    left++;
                }
            }
            return res;
        }

    }
}

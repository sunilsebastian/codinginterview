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
        public static String findSubString(String str, String pat)
        {
            int len1 = str.Length;
            int len2 = pat.Length;

            // check if string's length is less than pattern's 
            // length. If yes then no such window can exist 
            if (len1 < len2)
            {
                return "";
            }

            int[] hash_pat = new int[128];
            int[] hash_str = new int[128];

            // store occurrence ofs characters of pattern 
            for (int i = 0; i < len2; i++)
                hash_pat[pat[i]]++;

            int start = 0, start_index = -1, min_len = Int32.MaxValue;

            // start traversing the string 
            int count = 0; // count of characters 
            for (int j = 0; j < len1; j++)
            {
                // count occurrence of characters of string 
                hash_str[str[j]]++;

                // If string's char matches with pattern's char 
                // then increment count 
                if (hash_pat[str[j]] != 0 &&
                    hash_str[str[j]] <= hash_pat[str[j]])
                    count++;

                // if all the characters are matched 
                if (count == len2)
                {
                    // Try to minimize the window i.e., check if 
                    // any character is occurring more no. of times 
                    // than its occurrence in pattern, if yes 
                    // then remove it from starting and also remove 
                    // the useless characters. 
                    while (hash_str[str[start]] > hash_pat[str[start]]
                        || hash_pat[str[start]] == 0)
                    {

                        if (hash_str[str[start]] > hash_pat[str[start]])
                            hash_str[str[start]]--;
                        start++;
                    }

                    // update window size 
                    int len_window = j - start + 1;
                    if (min_len > len_window)
                    {
                        min_len = len_window;
                        start_index = start;
                    }
                }
            }

            // If no window found 
            if (start_index == -1)
            {
               
                return "";
            }

            // Return substring starting from start_index 
            // and length min_len 
            return str.Substring(start_index,min_len);
        }

    }
}

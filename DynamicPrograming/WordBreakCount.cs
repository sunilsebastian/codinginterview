using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class WordBreakCount
    {
        //How many ways we can break
        public static int GetWordBreakCount(List<string> dictionary, string txt)
        {
            var hashSet = new HashSet<string>(dictionary);
            int[] dp = new int[txt.Length + 1];
            dp[0] = 1;
            for (int l = 1; l <= txt.Length; l++)
            {
                var sb = new System.Text.StringBuilder();
                int sum = 0;

                for (int i = 0;i<l;i++)
                {
                    if (hashSet.Contains(txt.Substring(i, l - i)))
                    {
                        sum += dp[i];
                        sum %= 1000000007;
                    }
                }
                dp[l] = sum;
            }

            return dp[txt.Length];
        }


        // Input:
        //s = "abc"
        //wordDict = ["a","b","c","ab"]
        //        Output:
        //[
        //  a b c",
        //  "ab c"
        //]

       static Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public static  IList<string> WordBreakII(string s, IList<string> wordDict)
        {

            var res = WordBreakHelper(s, wordDict);
            return res;

        }

        public static List<string> WordBreakHelper(string s, IList<string> wordDict)
        {

            if (dict.ContainsKey(s))
                return dict[s];

            //
            List<string> result = new List<string>();
            
         
            foreach (var word in wordDict)
            {
                //if the word is in start of string   "a" is start of abc
                // "ab" is start of abc
                if (s.IndexOf(word) == 0)
                {
                    //if the word is in start of string and dict item length equal to word leng eg " c" and "c"
                    if (word.Length == s.Length)
                        result.Add(word);
                    else
                    {
                        //we need to recurse
                        //if the dict item in strting ,we have recurse rest of the string
                        //say "ab" found in "abc" we have recurse with letter "c"
                        var list = WordBreakHelper(s.Substring(word.Length), wordDict);

                        // construct new resultant word with current word and list items

                        foreach (var item in list)
                        {
                            result.Add(item.Length == 0 ? word : word + " " + item);
                        }

                    }

                }
            }
            // if you traverse all dictionary item for a word add the listto dictionary
           // eg "c" ["c"]
           // eg 'bc ["b c"]
           //eg   abc ["a b c"]
           // 'abc" ["a b c","ab c"]
            dict.Add(s, result);
            return result;
        }

    }
}

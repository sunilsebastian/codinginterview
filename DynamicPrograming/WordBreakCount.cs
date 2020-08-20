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
        //s = "catsanddog"
        //wordDict = ["cat", "cats", "and", "sand", "dog"]
        //        Output:
        //[
        //  "cats and dog",
        //  "cat sand dog"
        //]

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        public IList<string> WordBreakII(string s, IList<string> wordDict)
        {

            var res = WordBreakHelper(s, wordDict);
            return res;

        }

        public List<string> WordBreakHelper(string s, IList<string> wordDict)
        {

            if (dict.ContainsKey(s))
                return dict[s];

            List<string> result = new List<string>();

            foreach (var word in wordDict)
            {
                if (s.IndexOf(word) == 0)
                {
                    if (word.Length == s.Length)
                        result.Add(word);
                    else
                    {
                        var list = WordBreakHelper(s.Substring(word.Length), wordDict);
                        foreach (var item in list)
                        {
                            result.Add(item.Length == 0 ? word : word + " " + item);
                        }

                    }

                }
            }
            dict.Add(s, result);
            return result;
        }

    }
}

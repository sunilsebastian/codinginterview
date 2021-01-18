using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class CanBreakWord
    {
        public static bool WordBreak(string s, IList<string> wordDict)
        {
            Dictionary<string, bool> map = new Dictionary<string, bool>();
            return wordBreak(s, wordDict, map, 0);
        }

        public static bool wordBreak(string s, IList<string> wordDict, Dictionary<string, bool> map, int ti)
        {

            if (ti == s.Length)
                return true;
            if (map.ContainsKey(s.Substring(ti)))
                return map[s.Substring(ti)];

            for (int i = ti; i < s.Length; i++)
            {
                if (wordDict.Contains(s.Substring(ti, i - ti + 1)) &&
                        wordBreak(s, wordDict, map, i + 1))
                {
                    map[s.Substring(ti, i - ti + 1)] = true;
                    return true;
                }
            }


            map[s.Substring(ti)] = false;
            return false;
        }

        //DP refer book
    }
}

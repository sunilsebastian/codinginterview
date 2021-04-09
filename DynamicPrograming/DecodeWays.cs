using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    public class DecodeWays
    {
        public static int NumDecodings(string s)
        {
            int[] dp = new int[s.Length + 1];
            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1;
            for (int i = 2; i <= s.Length; i++)
            {


                int oneDigit = Int32.Parse(s.Substring(i - 1, 1));
                int twoDigit = Int32.Parse(s.Substring(i - 2, 2));

                //below also fine
                //int oneDigit = Int32.Parse(s.Substring(i - 2, 1));
                //int twoDigit = Int32.Parse(s.Substring(i - 2, 2));

                if (oneDigit >= 1)
                {
                    dp[i] += dp[i - 1];

                }
                if (twoDigit >= 10 && twoDigit <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }
            return dp[s.Length];
        }

        public static Dictionary<int, int> dict = new Dictionary<int, int>();

        public static  int NumDecodings1(string s)
        {
            // return recursiveWithMemo(0,s);
            //  return NumDecodingsHelper(s, 0);

            Dictionary<int, int> dict = new Dictionary<int, int>();
            return dfs(s, 0, dict);

        }
        public int NumDecodingsHelper(string s, int trackIndex)
        {

            if (trackIndex == s.Length - 1 || trackIndex == s.Length)
                return 1;

            if (s[trackIndex] == '0')
                return 0;


            if (dict.ContainsKey(trackIndex))
                return dict[trackIndex];
            int count = 0;
            for (int i = trackIndex; i <= trackIndex + 1; i++)
            {
                var val = Int32.Parse(s.Substring(trackIndex, (i - trackIndex) + 1));
                if (val <= 26)
                {
                    count += NumDecodingsHelper(s, i + 1);
                }

            }
            dict.Add(trackIndex, count);
            return count;

        }

        public int numDecodings(String s)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            return dfs(s, 0, dict);
        }

        public static int dfs(String s, int index, Dictionary<int, int> dict)
        {
            if (dict.ContainsKey(index))
            {
                return dict[index];
            }
            if (index == s.Length)
            {
                return 1;
            }
            if (s[index] == '0')
            {
                return 0;
            }

            if (index == s.Length - 1)
            {
                return 1;
            }
            int result = 0;
            
            result += dfs(s, index + 1, dict);
            if (Int32.Parse(s.Substring(index, 2)) <= 26)
            {
                result += dfs(s, index + 2, dict);
            }
            dict.Add(index, result);
            return result;
        }
    }
}

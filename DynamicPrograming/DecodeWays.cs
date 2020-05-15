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
            return NumDecodingsHelper(s, 0);

        }
        public static int NumDecodingsHelper(string s, int trackIndex)
        {
            if (trackIndex == s.Length - 1 || trackIndex == s.Length)
                return 1;

            if (s[trackIndex] == '0')
                return 0;
          

            if (dict.ContainsKey(trackIndex))
                return dict[trackIndex];
            int count = 0;
            //from trackindex we need to take 1 char and then 2 chars so loop run twice.
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

        private static int recursiveWithMemo(int index, String str)
        {

            // If you reach the end of the string
            // Return 1 for success.
            if (index == str.Length)
            {
                return 1;
            }

            // If the string starts with a zero, it can't be decoded
            if (str[index] == '0')
            {
                return 0;
            }

            if (index == str.Length - 1)
            {
                return 1;
            }

            // Memoization is needed since we might encounter the same sub-string.
            if (dict.ContainsKey(index))
            {
                return dict[index];
            }

            int ans = recursiveWithMemo(index + 1, str);
            if (Int32.Parse(str.Substring(index,2)) <= 26)
            {
                ans += recursiveWithMemo(index + 2, str);
            }

            // Save for memoization
            dict.Add(index, ans);

            return ans;
        }
    }
}
